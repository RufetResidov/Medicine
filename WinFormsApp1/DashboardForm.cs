using ApteklerSebekesi;
using ApteklerSebekesi.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WinFormsApp1
{
    public partial class DashboardForm : Form
    {
        ZeferanAptekContext db = new();
        public DashboardForm()
        {
            InitializeComponent();
        }

        #region tsmMedicineAdd_Click
        private void tsmMedicineAdd_Click(object sender, EventArgs e)
        {
            MedicineForm mf = new MedicineForm();
            mf.ShowDialog();
        }
        #endregion

        #region MedicineFillCombo
        private void MedicineFillCombo()
        {
            cmbMedicine.Items.AddRange(db.Medicines.Select(x => x.MedicineName).ToArray());
        }
        #endregion

        #region TagsFillCombo
        private void TagsFillCombo()
        {
            cmbTags.Items.AddRange(db.Tags.Select(x => x.Name).ToArray());
        }
        #endregion

        #region DashboardForm_Load
        private void DashboardForm_Load(object sender, EventArgs e)
        {
            MedicineFillCombo();
            TagsFillCombo();
            FillMedicineDataGrid();
        }
        #endregion

        #region cmbMedicine_SelectedIndexChanged
        private void cmbMedicine_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbTags.Text = "";
            FillMedicineDataGrid();
        }
        #endregion

        #region cmbMedicine_KeyUp
        private void cmbMedicine_KeyUp(object sender, KeyEventArgs e)
        {
            FillMedicineDataGrid();

        }
        #endregion


        private void FillMedicineDataGrid()
        {
            dtgMedicineList.DataSource = db.MedicineToTags
            .Where(x => x.Medicine.MedicineName.Contains(cmbMedicine.Text) &&
            x.Tag.Name.Contains(cmbTags.Text))
            .Select(x => new {
                x.MedicineId,
                Medicine_name = x.Medicine.MedicineName,
                x.Medicine.Price,
                x.Medicine.Quantity,
                Reseipt = x.Medicine.IsReseipt ? "Reseptli" : "Reseptsiz",
                Firm_Name = x.Medicine.Firm.Name,
                x.Medicine.Prodate,
                x.Medicine.ExperienceDate
            }).Distinct().ToList();
            dtgMedicineList.Columns[0].Visible = false;
            for (int i = 0; i < dtgMedicineList.RowCount; i++)
            {
                int quantity=(int)dtgMedicineList.Rows[i].Cells[3].Value;
                DateTime exDate=(DateTime)dtgMedicineList.Rows[i].Cells[7].Value;
                if (exDate >DateTime.Now)
                {
                    dtgMedicineList.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                    dtgMedicineList.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                }
                if (quantity <= 0)
                {
                    dtgMedicineList.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                    dtgMedicineList.Rows[i].DefaultCellStyle.BackColor = Color.Blue;
                }
                if (quantity <= 0 && exDate>DateTime.Now)
                {
                    dtgMedicineList.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                    dtgMedicineList.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                }
            }
        }

        private void cmbTags_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillMedicineDataGrid();
        }

        private void dtgMedicineList_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int MedId = (int)dtgMedicineList.Rows[e.RowIndex].Cells[0].Value;
            Medicine selectedMedicine = db.Medicines.First(x => x.MId == MedId);
            if (selectedMedicine.Quantity!=0 || selectedMedicine.ExperienceDate > DateTime.Now)
            {
                SellMedicinePanel.Visible = true;
                txtMedicine.Text = selectedMedicine.MedicineName;
                nmBuyCount.Maximum = selectedMedicine.Quantity;
                nmBuyCount.Value = 1;
            }
        }
        private void AddMedicineToList (string text)
        {
            if (!ckTagListDashboard.Items.Contains(text))
            {
                ckTagListDashboard.Items.Add(text,true);
            }
        }

        private void btnAddMedicine_Click(object sender, EventArgs e)
        {
            AddMedicineToList(txtMedicine.Text + "-" +nmBuyCount.Value);
        }

        private void ckTagListDashboard_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int selected = ckTagListDashboard.SelectedIndex;
            if (selected != -1)
            {
                ckTagListDashboard.Items.RemoveAt(selected);

            }
        }
        private void ClearAfterOrders()
        {
            ckTagListDashboard.Items.Clear();
            SellMedicinePanel.Visible = false;
        }
        private void btnBuyMedicine_Click(object sender, EventArgs e)
        {
            string result = "";
            for (int i = 0; i < ckTagListDashboard.Items.Count; i++)
            {
                string medicineItem = ckTagListDashboard.Items[i].ToString();
                string medName = medicineItem.Substring(0, medicineItem.LastIndexOf("-"));
                short  count =Convert.ToInt16(medicineItem.Substring( medicineItem.LastIndexOf("-") + 1));
                Medicine selectedMed = db.Medicines.First(x => x.MedicineName == medName);
                Order ord = new() {
                    WorkerId = 1,
                    MedicineId = selectedMed.MId,
                    PurchaseDate = DateTime.Now,
                    Amount = count,
                    Price = selectedMed.Price,
                };
                db.Orders.Add(ord);
                selectedMed.Quantity -= count;
                db.SaveChanges();
                result +=$"MedicineName:{medName},Quantity:{count},Price:{selectedMed.Price}Azn \n";
            }
            MessageBox.Show(result, "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            FillMedicineDataGrid();
            ClearAfterOrders();
        }

        private void btnBarcode_Click(object sender, EventArgs e)
        {
            BarcodeForm barForm = new BarcodeForm();
            barForm.ShowDialog();
        }
    }
}
