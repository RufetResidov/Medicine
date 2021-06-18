
namespace WinFormsApp1
{
    partial class DashboardForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmMedicine = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmMedicineAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmFirms = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbTags = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbMedicine = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgMedicineList = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.SellMedicinePanel = new System.Windows.Forms.Panel();
            this.btnBuyMedicine = new System.Windows.Forms.Button();
            this.ckTagListDashboard = new System.Windows.Forms.CheckedListBox();
            this.btnAddMedicine = new System.Windows.Forms.Button();
            this.nmBuyCount = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMedicine = new System.Windows.Forms.TextBox();
            this.btnExportExcel = new System.Windows.Forms.Button();
            this.btnBarcode = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMedicineList)).BeginInit();
            this.SellMedicinePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmBuyCount)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Teal;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmMedicine,
            this.tsmFirms});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 38);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmMedicine
            // 
            this.tsmMedicine.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmMedicineAdd});
            this.tsmMedicine.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tsmMedicine.ForeColor = System.Drawing.Color.Orange;
            this.tsmMedicine.Name = "tsmMedicine";
            this.tsmMedicine.Size = new System.Drawing.Size(120, 34);
            this.tsmMedicine.Text = "Medicine";
            // 
            // tsmMedicineAdd
            // 
            this.tsmMedicineAdd.ForeColor = System.Drawing.Color.Lime;
            this.tsmMedicineAdd.Name = "tsmMedicineAdd";
            this.tsmMedicineAdd.Size = new System.Drawing.Size(129, 34);
            this.tsmMedicineAdd.Text = "Add";
            this.tsmMedicineAdd.Click += new System.EventHandler(this.tsmMedicineAdd_Click);
            // 
            // tsmFirms
            // 
            this.tsmFirms.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tsmFirms.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.tsmFirms.Name = "tsmFirms";
            this.tsmFirms.Size = new System.Drawing.Size(81, 34);
            this.tsmFirms.Text = "Firms";
            // 
            // cmbTags
            // 
            this.cmbTags.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmbTags.FormattingEnabled = true;
            this.cmbTags.Location = new System.Drawing.Point(188, 266);
            this.cmbTags.Name = "cmbTags";
            this.cmbTags.Size = new System.Drawing.Size(161, 29);
            this.cmbTags.TabIndex = 9;
            this.cmbTags.SelectedIndexChanged += new System.EventHandler(this.cmbTags_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(188, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tags";
            // 
            // cmbMedicine
            // 
            this.cmbMedicine.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmbMedicine.FormattingEnabled = true;
            this.cmbMedicine.Location = new System.Drawing.Point(12, 266);
            this.cmbMedicine.Name = "cmbMedicine";
            this.cmbMedicine.Size = new System.Drawing.Size(155, 29);
            this.cmbMedicine.TabIndex = 7;
            this.cmbMedicine.SelectedIndexChanged += new System.EventHandler(this.cmbMedicine_SelectedIndexChanged);
            this.cmbMedicine.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cmbMedicine_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Medicine";
            // 
            // dtgMedicineList
            // 
            this.dtgMedicineList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgMedicineList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgMedicineList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgMedicineList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMedicineList.Location = new System.Drawing.Point(0, 338);
            this.dtgMedicineList.Name = "dtgMedicineList";
            this.dtgMedicineList.RowTemplate.Height = 25;
            this.dtgMedicineList.Size = new System.Drawing.Size(800, 140);
            this.dtgMedicineList.TabIndex = 5;
            this.dtgMedicineList.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgMedicineList_RowHeaderMouseDoubleClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Blue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(18, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Mehsul sayi bitib";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(114, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Mehsul tarixi bitib";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Green;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Green;
            this.button2.Location = new System.Drawing.Point(18, 112);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(114, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "Mehsul sayi ve tarixi bitib";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(18, 153);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 14;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // SellMedicinePanel
            // 
            this.SellMedicinePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SellMedicinePanel.Controls.Add(this.btnBuyMedicine);
            this.SellMedicinePanel.Controls.Add(this.ckTagListDashboard);
            this.SellMedicinePanel.Controls.Add(this.btnAddMedicine);
            this.SellMedicinePanel.Controls.Add(this.nmBuyCount);
            this.SellMedicinePanel.Controls.Add(this.label7);
            this.SellMedicinePanel.Controls.Add(this.label6);
            this.SellMedicinePanel.Controls.Add(this.txtMedicine);
            this.SellMedicinePanel.Location = new System.Drawing.Point(373, 46);
            this.SellMedicinePanel.Name = "SellMedicinePanel";
            this.SellMedicinePanel.Size = new System.Drawing.Size(427, 258);
            this.SellMedicinePanel.TabIndex = 16;
            this.SellMedicinePanel.Visible = false;
            // 
            // btnBuyMedicine
            // 
            this.btnBuyMedicine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnBuyMedicine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuyMedicine.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBuyMedicine.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBuyMedicine.Location = new System.Drawing.Point(183, 164);
            this.btnBuyMedicine.Name = "btnBuyMedicine";
            this.btnBuyMedicine.Size = new System.Drawing.Size(214, 34);
            this.btnBuyMedicine.TabIndex = 22;
            this.btnBuyMedicine.Text = "Buy";
            this.btnBuyMedicine.UseVisualStyleBackColor = false;
            this.btnBuyMedicine.Click += new System.EventHandler(this.btnBuyMedicine_Click);
            // 
            // ckTagListDashboard
            // 
            this.ckTagListDashboard.FormattingEnabled = true;
            this.ckTagListDashboard.Location = new System.Drawing.Point(183, 10);
            this.ckTagListDashboard.Name = "ckTagListDashboard";
            this.ckTagListDashboard.Size = new System.Drawing.Size(214, 148);
            this.ckTagListDashboard.TabIndex = 21;
            this.ckTagListDashboard.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ckTagListDashboard_MouseDoubleClick);
            // 
            // btnAddMedicine
            // 
            this.btnAddMedicine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAddMedicine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMedicine.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddMedicine.Location = new System.Drawing.Point(18, 122);
            this.btnAddMedicine.Name = "btnAddMedicine";
            this.btnAddMedicine.Size = new System.Drawing.Size(114, 34);
            this.btnAddMedicine.TabIndex = 20;
            this.btnAddMedicine.Text = "Add";
            this.btnAddMedicine.UseVisualStyleBackColor = false;
            this.btnAddMedicine.Click += new System.EventHandler(this.btnAddMedicine_Click);
            // 
            // nmBuyCount
            // 
            this.nmBuyCount.Location = new System.Drawing.Point(18, 81);
            this.nmBuyCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmBuyCount.Name = "nmBuyCount";
            this.nmBuyCount.Size = new System.Drawing.Size(114, 23);
            this.nmBuyCount.TabIndex = 19;
            this.nmBuyCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(18, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 21);
            this.label7.TabIndex = 18;
            this.label7.Text = "Count";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(18, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 21);
            this.label6.TabIndex = 17;
            this.label6.Text = "Medicine";
            // 
            // txtMedicine
            // 
            this.txtMedicine.Enabled = false;
            this.txtMedicine.Location = new System.Drawing.Point(18, 28);
            this.txtMedicine.Name = "txtMedicine";
            this.txtMedicine.Size = new System.Drawing.Size(114, 23);
            this.txtMedicine.TabIndex = 0;
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.BackColor = System.Drawing.Color.SlateBlue;
            this.btnExportExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportExcel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExportExcel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExportExcel.Location = new System.Drawing.Point(188, 200);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(161, 34);
            this.btnExportExcel.TabIndex = 23;
            this.btnExportExcel.Text = " Export Excel";
            this.btnExportExcel.UseVisualStyleBackColor = false;
            // 
            // btnBarcode
            // 
            this.btnBarcode.BackColor = System.Drawing.Color.SlateBlue;
            this.btnBarcode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBarcode.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBarcode.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBarcode.Location = new System.Drawing.Point(6, 200);
            this.btnBarcode.Name = "btnBarcode";
            this.btnBarcode.Size = new System.Drawing.Size(161, 34);
            this.btnBarcode.TabIndex = 24;
            this.btnBarcode.Text = "Barcode";
            this.btnBarcode.UseVisualStyleBackColor = false;
            this.btnBarcode.Click += new System.EventHandler(this.btnBarcode_Click);
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 478);
            this.Controls.Add(this.btnBarcode);
            this.Controls.Add(this.btnExportExcel);
            this.Controls.Add(this.SellMedicinePanel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbTags);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbMedicine);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgMedicineList);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DashboardForm";
            this.Text = "1";
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMedicineList)).EndInit();
            this.SellMedicinePanel.ResumeLayout(false);
            this.SellMedicinePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmBuyCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmMedicine;
        private System.Windows.Forms.ToolStripMenuItem tsmMedicineAdd;
        private System.Windows.Forms.ToolStripMenuItem tsmFirms;
        private System.Windows.Forms.ComboBox cmbTags;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbMedicine;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgMedicineForm;
        private System.Windows.Forms.DataGridView dtgMedicineList;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel SellMedicinePanel;
        private System.Windows.Forms.Button btnAddMedicine;
        private System.Windows.Forms.NumericUpDown nmBuyCount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMedicine;
        private System.Windows.Forms.CheckedListBox ckTagListDashboard;
        private System.Windows.Forms.Button btnBuyMedicine;
        private System.Windows.Forms.Button btnExportExcel;
        private System.Windows.Forms.Button btnBarcode;
    }
}

