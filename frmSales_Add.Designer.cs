namespace GSTBilling
{
    partial class frmSales_Add
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
            this.label9 = new System.Windows.Forms.Label();
            this.txtSalesRate = new System.Windows.Forms.NumericUpDown();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancle = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSubTotal = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTaxableValue = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.txtGstRate = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.txtGstAmount = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTotalAmount = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.txtSalesRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiscount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTaxableValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGstRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGstAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(84, 152);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 26);
            this.label9.TabIndex = 31;
            this.label9.Text = "Sales Rate";
            // 
            // txtSalesRate
            // 
            this.txtSalesRate.DecimalPlaces = 2;
            this.txtSalesRate.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtSalesRate.Location = new System.Drawing.Point(194, 150);
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
            this.txtSalesRate.TabIndex = 4;
            this.txtSalesRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSalesRate.ThousandsSeparator = true;
            this.txtSalesRate.Enter += new System.EventHandler(this.txtSalesRate_Enter);
            this.txtSalesRate.Leave += new System.EventHandler(this.txtGstRate_Leave);
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(446, 181);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(308, 333);
            this.txtRemarks.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(441, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 26);
            this.label7.TabIndex = 30;
            this.label7.Text = "Remarks";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(194, 93);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(561, 33);
            this.txtProductName.TabIndex = 2;
            this.txtProductName.Leave += new System.EventHandler(this.txtProductName_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 26);
            this.label2.TabIndex = 27;
            this.label2.Text = "Product Name";
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
            this.label1.Size = new System.Drawing.Size(784, 57);
            this.label1.TabIndex = 25;
            this.label1.Text = "Product Details";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCancle
            // 
            this.btnCancle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancle.Font = new System.Drawing.Font("Open Sans", 14F);
            this.btnCancle.Location = new System.Drawing.Point(616, 536);
            this.btnCancle.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(138, 46);
            this.btnCancle.TabIndex = 32;
            this.btnCancle.Text = "Cancle";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Font = new System.Drawing.Font("Open Sans", 14F);
            this.btnSave.Location = new System.Drawing.Point(466, 536);
            this.btnSave.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(138, 46);
            this.btnSave.TabIndex = 30;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 26);
            this.label3.TabIndex = 35;
            this.label3.Text = "Quantity";
            // 
            // txtQty
            // 
            this.txtQty.DecimalPlaces = 2;
            this.txtQty.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtQty.Location = new System.Drawing.Point(194, 207);
            this.txtQty.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.txtQty.Minimum = new decimal(new int[] {
            1410065407,
            2,
            0,
            -2147483648});
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(203, 33);
            this.txtQty.TabIndex = 6;
            this.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtQty.ThousandsSeparator = true;
            this.txtQty.Enter += new System.EventHandler(this.txtSalesRate_Enter);
            this.txtQty.Leave += new System.EventHandler(this.txtGstRate_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(92, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 26);
            this.label4.TabIndex = 37;
            this.label4.Text = "Sub Total";
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.DecimalPlaces = 2;
            this.txtSubTotal.Enabled = false;
            this.txtSubTotal.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtSubTotal.Location = new System.Drawing.Point(194, 264);
            this.txtSubTotal.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.txtSubTotal.Minimum = new decimal(new int[] {
            1410065407,
            2,
            0,
            -2147483648});
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Size = new System.Drawing.Size(203, 33);
            this.txtSubTotal.TabIndex = 8;
            this.txtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSubTotal.ThousandsSeparator = true;
            this.txtSubTotal.Enter += new System.EventHandler(this.txtSalesRate_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(97, 323);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 26);
            this.label5.TabIndex = 39;
            this.label5.Text = "Discount";
            // 
            // txtDiscount
            // 
            this.txtDiscount.DecimalPlaces = 2;
            this.txtDiscount.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtDiscount.Location = new System.Drawing.Point(194, 321);
            this.txtDiscount.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.txtDiscount.Minimum = new decimal(new int[] {
            1410065407,
            2,
            0,
            -2147483648});
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(203, 33);
            this.txtDiscount.TabIndex = 10;
            this.txtDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDiscount.ThousandsSeparator = true;
            this.txtDiscount.Enter += new System.EventHandler(this.txtSalesRate_Enter);
            this.txtDiscount.Leave += new System.EventHandler(this.txtGstRate_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(95, 437);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 26);
            this.label6.TabIndex = 41;
            this.label6.Text = "GST Rate";
            // 
            // txtTaxableValue
            // 
            this.txtTaxableValue.DecimalPlaces = 2;
            this.txtTaxableValue.Enabled = false;
            this.txtTaxableValue.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtTaxableValue.Location = new System.Drawing.Point(194, 378);
            this.txtTaxableValue.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.txtTaxableValue.Minimum = new decimal(new int[] {
            1410065407,
            2,
            0,
            -2147483648});
            this.txtTaxableValue.Name = "txtTaxableValue";
            this.txtTaxableValue.Size = new System.Drawing.Size(203, 33);
            this.txtTaxableValue.TabIndex = 12;
            this.txtTaxableValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTaxableValue.ThousandsSeparator = true;
            this.txtTaxableValue.Enter += new System.EventHandler(this.txtSalesRate_Enter);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(64, 494);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 26);
            this.label8.TabIndex = 43;
            this.label8.Text = "GST Amount";
            // 
            // txtGstRate
            // 
            this.txtGstRate.DecimalPlaces = 2;
            this.txtGstRate.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtGstRate.Location = new System.Drawing.Point(194, 435);
            this.txtGstRate.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.txtGstRate.Minimum = new decimal(new int[] {
            1410065407,
            2,
            0,
            -2147483648});
            this.txtGstRate.Name = "txtGstRate";
            this.txtGstRate.Size = new System.Drawing.Size(203, 33);
            this.txtGstRate.TabIndex = 14;
            this.txtGstRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtGstRate.ThousandsSeparator = true;
            this.txtGstRate.Enter += new System.EventHandler(this.txtSalesRate_Enter);
            this.txtGstRate.Leave += new System.EventHandler(this.txtGstRate_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(50, 380);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(138, 26);
            this.label10.TabIndex = 45;
            this.label10.Text = "Taxable Value";
            // 
            // txtGstAmount
            // 
            this.txtGstAmount.DecimalPlaces = 2;
            this.txtGstAmount.Enabled = false;
            this.txtGstAmount.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtGstAmount.Location = new System.Drawing.Point(194, 492);
            this.txtGstAmount.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.txtGstAmount.Minimum = new decimal(new int[] {
            1410065407,
            2,
            0,
            -2147483648});
            this.txtGstAmount.Name = "txtGstAmount";
            this.txtGstAmount.Size = new System.Drawing.Size(203, 33);
            this.txtGstAmount.TabIndex = 16;
            this.txtGstAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtGstAmount.ThousandsSeparator = true;
            this.txtGstAmount.Enter += new System.EventHandler(this.txtSalesRate_Enter);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Open Sans", 18F);
            this.label11.Location = new System.Drawing.Point(24, 551);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(164, 33);
            this.label11.TabIndex = 47;
            this.label11.Text = "Total Amount";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.DecimalPlaces = 2;
            this.txtTotalAmount.Enabled = false;
            this.txtTotalAmount.Font = new System.Drawing.Font("Open Sans", 18F);
            this.txtTotalAmount.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtTotalAmount.Location = new System.Drawing.Point(194, 549);
            this.txtTotalAmount.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.txtTotalAmount.Minimum = new decimal(new int[] {
            1410065407,
            2,
            0,
            -2147483648});
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.Size = new System.Drawing.Size(203, 40);
            this.txtTotalAmount.TabIndex = 18;
            this.txtTotalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotalAmount.ThousandsSeparator = true;
            // 
            // frmSales_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 633);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtTotalAmount);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtGstAmount);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtGstRate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTaxableValue);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSubTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtSalesRate);
            this.Controls.Add(this.txtRemarks);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Open Sans", 14F);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmSales_Add";
            this.Text = "frmSales_Add";
            this.Load += new System.EventHandler(this.frmSales_Add_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtSalesRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiscount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTaxableValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGstRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGstAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown txtSalesRate;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown txtQty;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown txtSubTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown txtDiscount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown txtTaxableValue;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown txtGstRate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown txtGstAmount;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown txtTotalAmount;
    }
}