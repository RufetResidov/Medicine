
namespace ApteklerSebekesi
{
    partial class BarcodeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCamera = new System.Windows.Forms.ComboBox();
            this.pcBarcodeCamera = new System.Windows.Forms.PictureBox();
            this.btnStartCamera = new System.Windows.Forms.Button();
            this.SellMedicinePanel = new System.Windows.Forms.Panel();
            this.btnBuyMedicine = new System.Windows.Forms.Button();
            this.ckTagListDashboard = new System.Windows.Forms.CheckedListBox();
            this.btnAddMedicine = new System.Windows.Forms.Button();
            this.nmBuyCount = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMedicine = new System.Windows.Forms.TextBox();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcBarcodeCamera)).BeginInit();
            this.SellMedicinePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmBuyCount)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Camera";
            // 
            // cmbCamera
            // 
            this.cmbCamera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCamera.FormattingEnabled = true;
            this.cmbCamera.Location = new System.Drawing.Point(86, 7);
            this.cmbCamera.Name = "cmbCamera";
            this.cmbCamera.Size = new System.Drawing.Size(170, 23);
            this.cmbCamera.TabIndex = 8;
            // 
            // pcBarcodeCamera
            // 
            this.pcBarcodeCamera.Location = new System.Drawing.Point(12, 49);
            this.pcBarcodeCamera.Name = "pcBarcodeCamera";
            this.pcBarcodeCamera.Size = new System.Drawing.Size(244, 222);
            this.pcBarcodeCamera.TabIndex = 9;
            this.pcBarcodeCamera.TabStop = false;
            // 
            // btnStartCamera
            // 
            this.btnStartCamera.BackColor = System.Drawing.Color.SlateBlue;
            this.btnStartCamera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartCamera.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnStartCamera.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnStartCamera.Location = new System.Drawing.Point(12, 333);
            this.btnStartCamera.Name = "btnStartCamera";
            this.btnStartCamera.Size = new System.Drawing.Size(244, 43);
            this.btnStartCamera.TabIndex = 24;
            this.btnStartCamera.Text = "Start";
            this.btnStartCamera.UseVisualStyleBackColor = false;
            this.btnStartCamera.Click += new System.EventHandler(this.btnStartCamera_Click);
            // 
            // SellMedicinePanel
            // 
            this.SellMedicinePanel.Controls.Add(this.btnBuyMedicine);
            this.SellMedicinePanel.Controls.Add(this.ckTagListDashboard);
            this.SellMedicinePanel.Controls.Add(this.btnAddMedicine);
            this.SellMedicinePanel.Controls.Add(this.nmBuyCount);
            this.SellMedicinePanel.Controls.Add(this.label7);
            this.SellMedicinePanel.Controls.Add(this.label6);
            this.SellMedicinePanel.Controls.Add(this.txtMedicine);
            this.SellMedicinePanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.SellMedicinePanel.Location = new System.Drawing.Point(326, 0);
            this.SellMedicinePanel.Name = "SellMedicinePanel";
            this.SellMedicinePanel.Size = new System.Drawing.Size(474, 450);
            this.SellMedicinePanel.TabIndex = 25;
            // 
            // btnBuyMedicine
            // 
            this.btnBuyMedicine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnBuyMedicine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuyMedicine.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBuyMedicine.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBuyMedicine.Location = new System.Drawing.Point(230, 321);
            this.btnBuyMedicine.Name = "btnBuyMedicine";
            this.btnBuyMedicine.Size = new System.Drawing.Size(232, 43);
            this.btnBuyMedicine.TabIndex = 22;
            this.btnBuyMedicine.Text = "Buy";
            this.btnBuyMedicine.UseVisualStyleBackColor = false;
            // 
            // ckTagListDashboard
            // 
            this.ckTagListDashboard.FormattingEnabled = true;
            this.ckTagListDashboard.Location = new System.Drawing.Point(230, 7);
            this.ckTagListDashboard.Name = "ckTagListDashboard";
            this.ckTagListDashboard.Size = new System.Drawing.Size(232, 310);
            this.ckTagListDashboard.TabIndex = 21;
            // 
            // btnAddMedicine
            // 
            this.btnAddMedicine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAddMedicine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMedicine.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddMedicine.Location = new System.Drawing.Point(18, 122);
            this.btnAddMedicine.Name = "btnAddMedicine";
            this.btnAddMedicine.Size = new System.Drawing.Size(151, 56);
            this.btnAddMedicine.TabIndex = 20;
            this.btnAddMedicine.Text = "Add";
            this.btnAddMedicine.UseVisualStyleBackColor = false;
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
            this.nmBuyCount.Size = new System.Drawing.Size(151, 23);
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
            this.txtMedicine.Size = new System.Drawing.Size(151, 23);
            this.txtMedicine.TabIndex = 0;
            // 
            // txtBarcode
            // 
            this.txtBarcode.Enabled = false;
            this.txtBarcode.Location = new System.Drawing.Point(12, 294);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(244, 23);
            this.txtBarcode.TabIndex = 23;
            // 
            // BarcodeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBarcode);
            this.Controls.Add(this.SellMedicinePanel);
            this.Controls.Add(this.btnStartCamera);
            this.Controls.Add(this.pcBarcodeCamera);
            this.Controls.Add(this.cmbCamera);
            this.Controls.Add(this.label1);
            this.Name = "BarcodeForm";
            this.Text = "BarcodeForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BarcodeForm_FormClosing);
            this.Load += new System.EventHandler(this.BarcodeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcBarcodeCamera)).EndInit();
            this.SellMedicinePanel.ResumeLayout(false);
            this.SellMedicinePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmBuyCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCamera;
        private System.Windows.Forms.PictureBox pcBarcodeCamera;
        private System.Windows.Forms.Button btnStartCamera;
        private System.Windows.Forms.Panel SellMedicinePanel;
        private System.Windows.Forms.Button btnBuyMedicine;
        private System.Windows.Forms.CheckedListBox ckTagListDashboard;
        private System.Windows.Forms.Button btnAddMedicine;
        private System.Windows.Forms.NumericUpDown nmBuyCount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMedicine;
        private System.Windows.Forms.TextBox txtBarcode;
    }
}