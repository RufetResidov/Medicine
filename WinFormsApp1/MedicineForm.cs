using ApteklerSebekesi.Helpers;
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

namespace ApteklerSebekesi
{
    public partial class MedicineForm : Form
    {
        ZeferanAptekContext db = new();
        public MedicineForm()
        {
            InitializeComponent();
        }
        #region FillFirmCombo
        public void FillFirmCombo()
        {
            cmbFirms.Items.AddRange(db.Firms.Select(x => x.Name).ToArray());
        }
        #endregion

        #region FillTagsCombo
        public void FillTagsCombo()
        {
            cmbTag.Items.AddRange(db.Tags.Select(x => x.Name).ToArray());
        }
        #endregion

        #region MedicineFormLoad 
        private void MedicineForm_Load(object sender, EventArgs e)
        {
            FillFirmCombo();
            FillTagsCombo();
            FillMedicineDataGrid();
        }
        #endregion

        #region FindFirm
        public int FindFirm(string firmName)
        {
            Firm selectedFirm = db.Firms.FirstOrDefault(x => x.Name == firmName);
            if (selectedFirm == null)
            {
                Firm firm = new Firm
                {
                    Name = firmName
                };
                db.AddRange(firm);
                db.SaveChanges();
                return firm.FId;
            }
            return selectedFirm.FId;
        }
        #endregion

        #region btnAddMedicineClick
        private void btnAddMedicine_Click(object sender, EventArgs e)
        {
            string medicineName = txtMedicineName.Text;
            string firmName = cmbFirms.Text;
            decimal price = nmPrice.Value;
            int count = (int)nmQuantity.Value;
            string barcode = txtBarcode.Text;
            string description = rcDescription.Text;
            string tags = cmbTag.Text;
            DateTime purchaseDate = dtPurDate.Value;
            DateTime experienceDate = dtExpDate.Value;
            bool isReseipt = ckBoxReseipt.Checked;
            string[] ar = { medicineName, firmName, barcode, description };
            if (Utilities.İsEmpty(ar))
            {
                lblError.Visible = false;
                int FirmId = FindFirm(firmName);
                if (purchaseDate > experienceDate)
                {
                    Medicine medicine = new Medicine
                    {
                        MedicineName = medicineName,
                        Price = price,
                        Quantity = count,
                        Barcode = Convert.ToInt32(barcode),
                        Description = description,
                        Prodate = purchaseDate,
                        ExperienceDate = experienceDate,
                        IsReseipt = isReseipt ? true : false,
                        FirmId = FirmId
                    };
                    db.Medicines.Add(medicine);
                    db.SaveChanges();
                    MedicineAddTag(medicine.MId);
                    MessageBox.Show("Medicine added succesfuly");
                    ClearFormData();
                    FillMedicineDataGrid();

                }
                else
                {
                    lblError.Text = "Experience date is valid";
                    lblError.Visible = true;
                }
            }
            else
            {
                lblError.Text = "Please all the fiel!";
                lblError.Visible = true;
            }
        }
        #endregion
        #region ClearFormData
        private void ClearFormData()
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox || item is ComboBox || item is RichTextBox)
                {
                    item.Text = "";
                }
                else if (item is NumericUpDown)
                {
                    NumericUpDown nm = (NumericUpDown)item;
                    nm.Value = 1;
                }
                else if (item is DateTimePicker)
                {
                    DateTimePicker dt = (DateTimePicker)item;
                    dt.Value = DateTime.Now;
                }
                else if (item is CheckedListBox)
                {
                    CheckedListBox ck = (CheckedListBox)item;
                    ck.Items.Clear();
                }
                else if (item is CheckBox)
                {
                    CheckBox ckbox = (CheckBox)item;
                    ckbox.Checked = false;
                }
            }
        }
        #endregion

        private bool CheckTagName(string tg)
        {
            Tag tag = db.Tags.FirstOrDefault(x => x.Name == tg);
            if (tag == null)
            {
                return false;
            }
            return true;
        }

        #region MedicineAddTag
        private void MedicineAddTag(int medicineID)
        {
            for (var i = 0; i < ckTagList.Items.Count; i++)
            {
                string tagName = ckTagList.Items[i].ToString();
                int TagID;
                if (CheckTagName(tagName))
                {
                    TagID = db.Tags.First(x => x.Name == tagName).TId;
                }
                else
                {
                    Tag tag = new()
                    {
                        Name = tagName
                    };
                    db.Tags.Add(tag);
                    db.SaveChanges();
                    TagID = tag.TId;
                }
                db.MedicineToTags.Add(new MedicineToTag
                {
                    MedicineId = medicineID,
                    TagId = TagID
                });
                db.SaveChanges();
            }
        }
        #endregion

        #region txtBarcode
        private void txtBarcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57 || txtBarcode.TextLength > 11) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
        #endregion

        private void FillMedicineDataGrid()
        {
            dtgMedicineList.DataSource = db.Medicines.Select(x => new{
                 Medicine_name=x.MedicineName,
                 x.Price,
                 x.Quantity,
                 Reseipt=x.IsReseipt?"Reseptli":"Reseptsiz",
                 Firm_Name=x.Firm.Name,
                 x.Prodate,
                 x.ExperienceDate
            }).ToList();
            for (int i = 0; i < dtgMedicineList.RowCount; i++)
            {
                if(dtgMedicineList.Rows[i].Index % 2 == 0)
                {
                    dtgMedicineList.Rows[i].DefaultCellStyle.BackColor = Color.Teal;
                    dtgMedicineList.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                }
            }
        }
        private void cmbTag_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tagName = cmbTag.Text;
            if (!ckTagList.Items.Contains(tagName))
            {
                ckTagList.Items.Add(tagName, true);
            }
        }

        private void cmbTag_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string tagName = cmbTag.Text;
                if (!ckTagList.Items.Contains(tagName))
                {
                    ckTagList.Items.Add(tagName,true);

                }
            }
        }

        private void ckTagList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int selected = ckTagList.SelectedIndex;
            if (selected != -1)
            {
                ckTagList.Items.RemoveAt(selected);

            }
        }

      
    }
}
