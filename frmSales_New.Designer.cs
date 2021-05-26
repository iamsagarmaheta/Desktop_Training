namespace GSTBilling
{
    partial class frmSales_New
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSales_New));
            this.label1 = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtInvoiceNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpInvoiceDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSubTotal = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.btnCancle = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtContactNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gvSalesData = new System.Windows.Forms.DataGridView();
            this.gvcId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvcInvoiceDataId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvcProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvcProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvcQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvcSalesRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvcSubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvcDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvcTaxableValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvcTaxRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvcTaxAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvcTotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvcIsDeleted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvcCreated_TimeStamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvcUpdatedTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvcCreatedUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvcUpdatedUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTaxableValue = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTaxAmount = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.txtRoundOff = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.txtGrandTotal = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtIgstAmt = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.txtSgstAmt = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.txtCgstAmt = new System.Windows.Forms.NumericUpDown();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.cmbGstType = new System.Windows.Forms.ComboBox();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnEditItem = new System.Windows.Forms.Button();
            this.btnDeleteItem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSalesData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiscount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTaxableValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTaxAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRoundOff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGrandTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIgstAmt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSgstAmt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCgstAmt)).BeginInit();
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
            this.label1.Size = new System.Drawing.Size(1201, 57);
            this.label1.TabIndex = 1;
            this.label1.Text = "Invoice Details";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(177, 76);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(403, 33);
            this.txtCustomerName.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 26);
            this.label3.TabIndex = 12;
            this.label3.Text = "Customer Name";
            // 
            // txtInvoiceNo
            // 
            this.txtInvoiceNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInvoiceNo.Location = new System.Drawing.Point(971, 124);
            this.txtInvoiceNo.Name = "txtInvoiceNo";
            this.txtInvoiceNo.Size = new System.Drawing.Size(203, 33);
            this.txtInvoiceNo.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(860, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 26);
            this.label2.TabIndex = 11;
            this.label2.Text = "Invoice No";
            // 
            // dtpInvoiceDate
            // 
            this.dtpInvoiceDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpInvoiceDate.CustomFormat = "dd-MM-yyyy";
            this.dtpInvoiceDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpInvoiceDate.Location = new System.Drawing.Point(971, 74);
            this.dtpInvoiceDate.Name = "dtpInvoiceDate";
            this.dtpInvoiceDate.Size = new System.Drawing.Size(203, 33);
            this.dtpInvoiceDate.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(842, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 26);
            this.label4.TabIndex = 14;
            this.label4.Text = "Invoice Date";
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSubTotal.DecimalPlaces = 2;
            this.txtSubTotal.Enabled = false;
            this.txtSubTotal.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtSubTotal.Location = new System.Drawing.Point(912, 541);
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
            this.txtSubTotal.TabIndex = 12;
            this.txtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSubTotal.ThousandsSeparator = true;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(807, 543);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 26);
            this.label9.TabIndex = 24;
            this.label9.Text = "Sub Total";
            // 
            // btnCancle
            // 
            this.btnCancle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancle.Font = new System.Drawing.Font("Open Sans", 14F);
            this.btnCancle.Location = new System.Drawing.Point(974, 828);
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
            this.btnSave.Location = new System.Drawing.Point(824, 828);
            this.btnSave.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(138, 46);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtContactNo
            // 
            this.txtContactNo.Location = new System.Drawing.Point(177, 124);
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.Size = new System.Drawing.Size(403, 33);
            this.txtContactNo.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 26);
            this.label5.TabIndex = 26;
            this.label5.Text = "Contact No";
            // 
            // gvSalesData
            // 
            this.gvSalesData.AllowUserToAddRows = false;
            this.gvSalesData.AllowUserToDeleteRows = false;
            this.gvSalesData.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(214)))), ((int)(((byte)(229)))));
            this.gvSalesData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gvSalesData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvSalesData.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gvSalesData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvSalesData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gvcId,
            this.gvcInvoiceDataId,
            this.gvcProductId,
            this.gvcProductName,
            this.gvcQty,
            this.gvcSalesRate,
            this.gvcSubTotal,
            this.gvcDiscount,
            this.gvcTaxableValue,
            this.gvcTaxRate,
            this.gvcTaxAmount,
            this.gvcTotalAmount,
            this.gvcIsDeleted,
            this.gvcCreated_TimeStamp,
            this.gvcUpdatedTime,
            this.gvcCreatedUser,
            this.gvcUpdatedUser});
            this.gvSalesData.Location = new System.Drawing.Point(12, 178);
            this.gvSalesData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gvSalesData.MultiSelect = false;
            this.gvSalesData.Name = "gvSalesData";
            this.gvSalesData.ReadOnly = true;
            this.gvSalesData.RowHeadersVisible = false;
            this.gvSalesData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.gvSalesData.RowTemplate.Height = 40;
            this.gvSalesData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvSalesData.Size = new System.Drawing.Size(1103, 345);
            this.gvSalesData.TabIndex = 27000;
            // 
            // gvcId
            // 
            this.gvcId.DataPropertyName = "Id";
            this.gvcId.HeaderText = "ID";
            this.gvcId.Name = "gvcId";
            this.gvcId.ReadOnly = true;
            // 
            // gvcInvoiceDataId
            // 
            this.gvcInvoiceDataId.DataPropertyName = "InvoiceDataId";
            this.gvcInvoiceDataId.HeaderText = "Invoice Data Id";
            this.gvcInvoiceDataId.Name = "gvcInvoiceDataId";
            this.gvcInvoiceDataId.ReadOnly = true;
            // 
            // gvcProductId
            // 
            this.gvcProductId.DataPropertyName = "ProductDataId";
            this.gvcProductId.HeaderText = "Product Id";
            this.gvcProductId.Name = "gvcProductId";
            this.gvcProductId.ReadOnly = true;
            // 
            // gvcProductName
            // 
            this.gvcProductName.DataPropertyName = "ProductName";
            this.gvcProductName.HeaderText = "Product Name";
            this.gvcProductName.Name = "gvcProductName";
            this.gvcProductName.ReadOnly = true;
            this.gvcProductName.Width = 250;
            // 
            // gvcQty
            // 
            this.gvcQty.DataPropertyName = "Quantity";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.gvcQty.DefaultCellStyle = dataGridViewCellStyle2;
            this.gvcQty.HeaderText = "Quantity";
            this.gvcQty.Name = "gvcQty";
            this.gvcQty.ReadOnly = true;
            this.gvcQty.Width = 120;
            // 
            // gvcSalesRate
            // 
            this.gvcSalesRate.DataPropertyName = "SalesRate";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            this.gvcSalesRate.DefaultCellStyle = dataGridViewCellStyle3;
            this.gvcSalesRate.HeaderText = "Sales Rate";
            this.gvcSalesRate.Name = "gvcSalesRate";
            this.gvcSalesRate.ReadOnly = true;
            this.gvcSalesRate.Width = 120;
            // 
            // gvcSubTotal
            // 
            this.gvcSubTotal.DataPropertyName = "SubTotal";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N2";
            this.gvcSubTotal.DefaultCellStyle = dataGridViewCellStyle4;
            this.gvcSubTotal.HeaderText = "Sub Total";
            this.gvcSubTotal.Name = "gvcSubTotal";
            this.gvcSubTotal.ReadOnly = true;
            this.gvcSubTotal.Width = 150;
            // 
            // gvcDiscount
            // 
            this.gvcDiscount.DataPropertyName = "Discount";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N2";
            this.gvcDiscount.DefaultCellStyle = dataGridViewCellStyle5;
            this.gvcDiscount.HeaderText = "Discount";
            this.gvcDiscount.Name = "gvcDiscount";
            this.gvcDiscount.ReadOnly = true;
            this.gvcDiscount.Width = 120;
            // 
            // gvcTaxableValue
            // 
            this.gvcTaxableValue.DataPropertyName = "TaxableValue";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N2";
            this.gvcTaxableValue.DefaultCellStyle = dataGridViewCellStyle6;
            this.gvcTaxableValue.HeaderText = "Taxable Value";
            this.gvcTaxableValue.Name = "gvcTaxableValue";
            this.gvcTaxableValue.ReadOnly = true;
            this.gvcTaxableValue.Width = 120;
            // 
            // gvcTaxRate
            // 
            this.gvcTaxRate.DataPropertyName = "TaxRate";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "N2";
            this.gvcTaxRate.DefaultCellStyle = dataGridViewCellStyle7;
            this.gvcTaxRate.HeaderText = "Tax Rate";
            this.gvcTaxRate.Name = "gvcTaxRate";
            this.gvcTaxRate.ReadOnly = true;
            this.gvcTaxRate.Width = 120;
            // 
            // gvcTaxAmount
            // 
            this.gvcTaxAmount.DataPropertyName = "TaxAmount";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Format = "N2";
            this.gvcTaxAmount.DefaultCellStyle = dataGridViewCellStyle8;
            this.gvcTaxAmount.HeaderText = "Tax Amount";
            this.gvcTaxAmount.Name = "gvcTaxAmount";
            this.gvcTaxAmount.ReadOnly = true;
            this.gvcTaxAmount.Width = 120;
            // 
            // gvcTotalAmount
            // 
            this.gvcTotalAmount.DataPropertyName = "TotalAmount";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.Format = "N2";
            this.gvcTotalAmount.DefaultCellStyle = dataGridViewCellStyle9;
            this.gvcTotalAmount.HeaderText = "Total Amount";
            this.gvcTotalAmount.Name = "gvcTotalAmount";
            this.gvcTotalAmount.ReadOnly = true;
            this.gvcTotalAmount.Width = 120;
            // 
            // gvcIsDeleted
            // 
            this.gvcIsDeleted.DataPropertyName = "IsDeleted";
            this.gvcIsDeleted.HeaderText = "Is Deleted";
            this.gvcIsDeleted.Name = "gvcIsDeleted";
            this.gvcIsDeleted.ReadOnly = true;
            // 
            // gvcCreated_TimeStamp
            // 
            this.gvcCreated_TimeStamp.DataPropertyName = "Created_Timestamp";
            this.gvcCreated_TimeStamp.HeaderText = "Created Time";
            this.gvcCreated_TimeStamp.Name = "gvcCreated_TimeStamp";
            this.gvcCreated_TimeStamp.ReadOnly = true;
            // 
            // gvcUpdatedTime
            // 
            this.gvcUpdatedTime.DataPropertyName = "Updated_Timestamp";
            this.gvcUpdatedTime.HeaderText = "Updated Time";
            this.gvcUpdatedTime.Name = "gvcUpdatedTime";
            this.gvcUpdatedTime.ReadOnly = true;
            // 
            // gvcCreatedUser
            // 
            this.gvcCreatedUser.DataPropertyName = "Created_User";
            this.gvcCreatedUser.HeaderText = "CreatedUser";
            this.gvcCreatedUser.Name = "gvcCreatedUser";
            this.gvcCreatedUser.ReadOnly = true;
            // 
            // gvcUpdatedUser
            // 
            this.gvcUpdatedUser.DataPropertyName = "Updated_User";
            this.gvcUpdatedUser.HeaderText = "Updated User";
            this.gvcUpdatedUser.Name = "gvcUpdatedUser";
            this.gvcUpdatedUser.ReadOnly = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1135, 882);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 26);
            this.label6.TabIndex = 28;
            this.label6.Text = ".";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(812, 582);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 26);
            this.label7.TabIndex = 30;
            this.label7.Text = "Discount";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDiscount.DecimalPlaces = 2;
            this.txtDiscount.Enabled = false;
            this.txtDiscount.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtDiscount.Location = new System.Drawing.Point(912, 580);
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
            this.txtDiscount.TabIndex = 29;
            this.txtDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDiscount.ThousandsSeparator = true;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(765, 621);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 26);
            this.label8.TabIndex = 32;
            this.label8.Text = "Taxable Value";
            // 
            // txtTaxableValue
            // 
            this.txtTaxableValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTaxableValue.DecimalPlaces = 2;
            this.txtTaxableValue.Enabled = false;
            this.txtTaxableValue.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtTaxableValue.Location = new System.Drawing.Point(912, 619);
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
            this.txtTaxableValue.TabIndex = 31;
            this.txtTaxableValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTaxableValue.ThousandsSeparator = true;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(782, 660);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 26);
            this.label10.TabIndex = 34;
            this.label10.Text = "Tax Amount";
            // 
            // txtTaxAmount
            // 
            this.txtTaxAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTaxAmount.DecimalPlaces = 2;
            this.txtTaxAmount.Enabled = false;
            this.txtTaxAmount.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtTaxAmount.Location = new System.Drawing.Point(912, 658);
            this.txtTaxAmount.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.txtTaxAmount.Minimum = new decimal(new int[] {
            1410065407,
            2,
            0,
            -2147483648});
            this.txtTaxAmount.Name = "txtTaxAmount";
            this.txtTaxAmount.Size = new System.Drawing.Size(203, 33);
            this.txtTaxAmount.TabIndex = 33;
            this.txtTaxAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTaxAmount.ThousandsSeparator = true;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(799, 699);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 26);
            this.label11.TabIndex = 36;
            this.label11.Text = "Round Off";
            // 
            // txtRoundOff
            // 
            this.txtRoundOff.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRoundOff.DecimalPlaces = 2;
            this.txtRoundOff.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtRoundOff.Location = new System.Drawing.Point(909, 697);
            this.txtRoundOff.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.txtRoundOff.Minimum = new decimal(new int[] {
            1410065407,
            2,
            0,
            -2147483648});
            this.txtRoundOff.Name = "txtRoundOff";
            this.txtRoundOff.Size = new System.Drawing.Size(203, 33);
            this.txtRoundOff.TabIndex = 18;
            this.txtRoundOff.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRoundOff.ThousandsSeparator = true;
            this.txtRoundOff.Enter += new System.EventHandler(this.txtRoundOff_Enter);
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Open Sans", 18F);
            this.label12.Location = new System.Drawing.Point(758, 760);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(145, 33);
            this.label12.TabIndex = 38;
            this.label12.Text = "Grand Total";
            // 
            // txtGrandTotal
            // 
            this.txtGrandTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGrandTotal.DecimalPlaces = 2;
            this.txtGrandTotal.Enabled = false;
            this.txtGrandTotal.Font = new System.Drawing.Font("Open Sans", 18F);
            this.txtGrandTotal.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtGrandTotal.Location = new System.Drawing.Point(909, 758);
            this.txtGrandTotal.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.txtGrandTotal.Minimum = new decimal(new int[] {
            1410065407,
            2,
            0,
            -2147483648});
            this.txtGrandTotal.Name = "txtGrandTotal";
            this.txtGrandTotal.Size = new System.Drawing.Size(203, 40);
            this.txtGrandTotal.TabIndex = 37;
            this.txtGrandTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtGrandTotal.ThousandsSeparator = true;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(375, 549);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(96, 26);
            this.label13.TabIndex = 39;
            this.label13.Text = "GST Type";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(419, 661);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 26);
            this.label14.TabIndex = 45;
            this.label14.Text = "IGST";
            // 
            // txtIgstAmt
            // 
            this.txtIgstAmt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIgstAmt.DecimalPlaces = 2;
            this.txtIgstAmt.Enabled = false;
            this.txtIgstAmt.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtIgstAmt.Location = new System.Drawing.Point(477, 661);
            this.txtIgstAmt.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.txtIgstAmt.Minimum = new decimal(new int[] {
            1410065407,
            2,
            0,
            -2147483648});
            this.txtIgstAmt.Name = "txtIgstAmt";
            this.txtIgstAmt.Size = new System.Drawing.Size(203, 33);
            this.txtIgstAmt.TabIndex = 44;
            this.txtIgstAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtIgstAmt.ThousandsSeparator = true;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(414, 622);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(57, 26);
            this.label15.TabIndex = 43;
            this.label15.Text = "SGST";
            // 
            // txtSgstAmt
            // 
            this.txtSgstAmt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSgstAmt.DecimalPlaces = 2;
            this.txtSgstAmt.Enabled = false;
            this.txtSgstAmt.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtSgstAmt.Location = new System.Drawing.Point(477, 622);
            this.txtSgstAmt.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.txtSgstAmt.Minimum = new decimal(new int[] {
            1410065407,
            2,
            0,
            -2147483648});
            this.txtSgstAmt.Name = "txtSgstAmt";
            this.txtSgstAmt.Size = new System.Drawing.Size(203, 33);
            this.txtSgstAmt.TabIndex = 42;
            this.txtSgstAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSgstAmt.ThousandsSeparator = true;
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(412, 585);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(59, 26);
            this.label16.TabIndex = 41;
            this.label16.Text = "CGST";
            // 
            // txtCgstAmt
            // 
            this.txtCgstAmt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCgstAmt.DecimalPlaces = 2;
            this.txtCgstAmt.Enabled = false;
            this.txtCgstAmt.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtCgstAmt.Location = new System.Drawing.Point(477, 583);
            this.txtCgstAmt.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.txtCgstAmt.Minimum = new decimal(new int[] {
            1410065407,
            2,
            0,
            -2147483648});
            this.txtCgstAmt.Name = "txtCgstAmt";
            this.txtCgstAmt.Size = new System.Drawing.Size(203, 33);
            this.txtCgstAmt.TabIndex = 40;
            this.txtCgstAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCgstAmt.ThousandsSeparator = true;
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(17, 586);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(330, 213);
            this.txtRemarks.TabIndex = 16;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(12, 552);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(91, 26);
            this.label17.TabIndex = 47;
            this.label17.Text = "Remarks";
            // 
            // cmbGstType
            // 
            this.cmbGstType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbGstType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGstType.FormattingEnabled = true;
            this.cmbGstType.Location = new System.Drawing.Point(477, 541);
            this.cmbGstType.Name = "cmbGstType";
            this.cmbGstType.Size = new System.Drawing.Size(203, 34);
            this.cmbGstType.TabIndex = 14;
            // 
            // btnAddItem
            // 
            this.btnAddItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddItem.BackgroundImage")));
            this.btnAddItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAddItem.Font = new System.Drawing.Font("Open Sans", 14F);
            this.btnAddItem.Location = new System.Drawing.Point(1124, 178);
            this.btnAddItem.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(50, 50);
            this.btnAddItem.TabIndex = 8;
            this.btnAddItem.UseVisualStyleBackColor = true;
            // 
            // btnEditItem
            // 
            this.btnEditItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditItem.BackgroundImage")));
            this.btnEditItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEditItem.Font = new System.Drawing.Font("Open Sans", 14F);
            this.btnEditItem.Location = new System.Drawing.Point(1124, 242);
            this.btnEditItem.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnEditItem.Name = "btnEditItem";
            this.btnEditItem.Size = new System.Drawing.Size(50, 50);
            this.btnEditItem.TabIndex = 10;
            this.btnEditItem.UseVisualStyleBackColor = true;
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeleteItem.BackgroundImage")));
            this.btnDeleteItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDeleteItem.Font = new System.Drawing.Font("Open Sans", 14F);
            this.btnDeleteItem.Location = new System.Drawing.Point(1124, 306);
            this.btnDeleteItem.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(50, 50);
            this.btnDeleteItem.TabIndex = 12;
            this.btnDeleteItem.UseVisualStyleBackColor = true;
            // 
            // frmSales_New
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1218, 661);
            this.Controls.Add(this.btnDeleteItem);
            this.Controls.Add(this.btnEditItem);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.cmbGstType);
            this.Controls.Add(this.txtRemarks);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtIgstAmt);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtSgstAmt);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtCgstAmt);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtGrandTotal);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtRoundOff);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtTaxAmount);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTaxableValue);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.gvSalesData);
            this.Controls.Add(this.txtContactNo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtSubTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpInvoiceDate);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtInvoiceNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmSales_New";
            this.Text = "frmProduct_New";
            this.Load += new System.EventHandler(this.frmSales_New_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtSubTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSalesData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiscount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTaxableValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTaxAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRoundOff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGrandTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIgstAmt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSgstAmt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCgstAmt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtInvoiceNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpInvoiceDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown txtSubTotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtContactNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView gvSalesData;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown txtDiscount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown txtTaxableValue;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown txtTaxAmount;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown txtRoundOff;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown txtGrandTotal;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown txtIgstAmt;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown txtSgstAmt;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown txtCgstAmt;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cmbGstType;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvcId;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvcInvoiceDataId;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvcProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvcProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvcQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvcSalesRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvcSubTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvcDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvcTaxableValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvcTaxRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvcTaxAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvcTotalAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvcIsDeleted;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvcCreated_TimeStamp;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvcUpdatedTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvcCreatedUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvcUpdatedUser;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnEditItem;
        private System.Windows.Forms.Button btnDeleteItem;
    }
}