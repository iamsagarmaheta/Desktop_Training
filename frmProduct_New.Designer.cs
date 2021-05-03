namespace GSTBilling
{
    partial class frmProduct_New
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
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpEntryDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHsnCode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPurchaseRate = new System.Windows.Forms.NumericUpDown();
            this.txtSalesRate = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnCancle = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtPurchaseRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSalesRate)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Blue;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Open Sans", 18F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(636, 57);
            this.label1.TabIndex = 1;
            this.label1.Text = "Product Details";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(194, 197);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(401, 33);
            this.txtProductName.TabIndex = 4;
            this.txtProductName.Leave += new System.EventHandler(this.txtProductName_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 26);
            this.label3.TabIndex = 12;
            this.label3.Text = "Product Name";
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Location = new System.Drawing.Point(194, 145);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(401, 33);
            this.txtCategoryName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 26);
            this.label2.TabIndex = 11;
            this.label2.Text = "Category Name";
            // 
            // dtpEntryDate
            // 
            this.dtpEntryDate.CustomFormat = "dd-MM-yyyy";
            this.dtpEntryDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEntryDate.Location = new System.Drawing.Point(194, 93);
            this.dtpEntryDate.Name = "dtpEntryDate";
            this.dtpEntryDate.Size = new System.Drawing.Size(203, 33);
            this.dtpEntryDate.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 26);
            this.label4.TabIndex = 14;
            this.label4.Text = "Entry Date";
            // 
            // txtHsnCode
            // 
            this.txtHsnCode.Location = new System.Drawing.Point(194, 301);
            this.txtHsnCode.Name = "txtHsnCode";
            this.txtHsnCode.Size = new System.Drawing.Size(203, 33);
            this.txtHsnCode.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(87, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 26);
            this.label5.TabIndex = 18;
            this.label5.Text = "HSN Code";
            // 
            // txtUnit
            // 
            this.txtUnit.Location = new System.Drawing.Point(194, 249);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Size = new System.Drawing.Size(203, 33);
            this.txtUnit.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(138, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 26);
            this.label6.TabIndex = 17;
            this.label6.Text = "Unit";
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(194, 457);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(401, 88);
            this.txtRemarks.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(97, 460);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 26);
            this.label7.TabIndex = 20;
            this.label7.Text = "Remarks";
            // 
            // txtPurchaseRate
            // 
            this.txtPurchaseRate.DecimalPlaces = 2;
            this.txtPurchaseRate.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtPurchaseRate.Location = new System.Drawing.Point(194, 353);
            this.txtPurchaseRate.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.txtPurchaseRate.Minimum = new decimal(new int[] {
            1410065407,
            2,
            0,
            -2147483648});
            this.txtPurchaseRate.Name = "txtPurchaseRate";
            this.txtPurchaseRate.Size = new System.Drawing.Size(203, 33);
            this.txtPurchaseRate.TabIndex = 10;
            this.txtPurchaseRate.ThousandsSeparator = true;
            this.txtPurchaseRate.Enter += new System.EventHandler(this.frmProduct_New_Enter);
            // 
            // txtSalesRate
            // 
            this.txtSalesRate.DecimalPlaces = 2;
            this.txtSalesRate.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtSalesRate.Location = new System.Drawing.Point(194, 405);
            this.txtSalesRate.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.txtSalesRate.Minimum = new decimal(new int[] {
            1410065407,
            2,
            0,
            -2147483648});
            this.txtSalesRate.Name = "txtSalesRate";
            this.txtSalesRate.Size = new System.Drawing.Size(203, 33);
            this.txtSalesRate.TabIndex = 12;
            this.txtSalesRate.ThousandsSeparator = true;
            this.txtSalesRate.Enter += new System.EventHandler(this.frmProduct_New_Enter);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(47, 355);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 26);
            this.label8.TabIndex = 23;
            this.label8.Text = "Purchase Rate";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(84, 407);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 26);
            this.label9.TabIndex = 24;
            this.label9.Text = "Sales Rate";
            // 
            // btnCancle
            // 
            this.btnCancle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancle.Font = new System.Drawing.Font("Open Sans", 14F);
            this.btnCancle.Location = new System.Drawing.Point(457, 579);
            this.btnCancle.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(138, 46);
            this.btnCancle.TabIndex = 24;
            this.btnCancle.Text = "Cancle";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Font = new System.Drawing.Font("Open Sans", 14F);
            this.btnSave.Location = new System.Drawing.Point(307, 579);
            this.btnSave.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(138, 46);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmProduct_New
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 663);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtSalesRate);
            this.Controls.Add(this.txtPurchaseRate);
            this.Controls.Add(this.txtRemarks);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtHsnCode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtUnit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpEntryDate);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCategoryName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmProduct_New";
            this.Text = "frmProduct_New";
            this.Load += new System.EventHandler(this.frmProduct_New_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtPurchaseRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSalesRate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpEntryDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHsnCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown txtPurchaseRate;
        private System.Windows.Forms.NumericUpDown txtSalesRate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Button btnSave;
    }
}