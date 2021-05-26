namespace GSTBilling
{
    partial class frmSales_List
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
            this.txtContactPerson = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gvCustomerData = new System.Windows.Forms.DataGridView();
            this.gvcId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvcNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvcJoinDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvcCustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvcContactPerson = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvcContactNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvcOutstandingBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gvCustomerData)).BeginInit();
            this.SuspendLayout();
            // 
            // txtContactPerson
            // 
            this.txtContactPerson.Location = new System.Drawing.Point(177, 119);
            this.txtContactPerson.Name = "txtContactPerson";
            this.txtContactPerson.Size = new System.Drawing.Size(401, 33);
            this.txtContactPerson.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 26);
            this.label3.TabIndex = 17;
            this.label3.Text = "Contact Person";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(178, 77);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(401, 33);
            this.txtCustomerName.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 26);
            this.label2.TabIndex = 14;
            this.label2.Text = "Customer Name";
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Font = new System.Drawing.Font("Open Sans", 14F);
            this.btnDelete.Location = new System.Drawing.Point(1036, 129);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(138, 46);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Font = new System.Drawing.Font("Open Sans", 14F);
            this.btnEdit.Location = new System.Drawing.Point(886, 129);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(138, 46);
            this.btnEdit.TabIndex = 13;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Font = new System.Drawing.Font("Open Sans", 14F);
            this.btnSearch.Location = new System.Drawing.Point(736, 70);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(288, 46);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExport.Font = new System.Drawing.Font("Open Sans", 14F);
            this.btnExport.Location = new System.Drawing.Point(1036, 70);
            this.btnExport.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(138, 46);
            this.btnExport.TabIndex = 16;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnNew
            // 
            this.btnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNew.Font = new System.Drawing.Font("Open Sans", 14F);
            this.btnNew.Location = new System.Drawing.Point(736, 129);
            this.btnNew.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(138, 46);
            this.btnNew.TabIndex = 12;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Open Sans", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1184, 50);
            this.label1.TabIndex = 18;
            this.label1.Text = "Sales Invoice";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gvCustomerData
            // 
            this.gvCustomerData.AllowUserToAddRows = false;
            this.gvCustomerData.AllowUserToDeleteRows = false;
            this.gvCustomerData.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(214)))), ((int)(((byte)(229)))));
            this.gvCustomerData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gvCustomerData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvCustomerData.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gvCustomerData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvCustomerData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gvcId,
            this.gvcNo,
            this.gvcJoinDate,
            this.gvcCustomerName,
            this.gvcContactPerson,
            this.gvcContactNumber,
            this.gvcOutstandingBalance});
            this.gvCustomerData.Location = new System.Drawing.Point(12, 186);
            this.gvCustomerData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gvCustomerData.MultiSelect = false;
            this.gvCustomerData.Name = "gvCustomerData";
            this.gvCustomerData.ReadOnly = true;
            this.gvCustomerData.RowHeadersVisible = false;
            this.gvCustomerData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.gvCustomerData.RowTemplate.Height = 40;
            this.gvCustomerData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvCustomerData.Size = new System.Drawing.Size(1160, 362);
            this.gvCustomerData.TabIndex = 19;
            // 
            // gvcId
            // 
            this.gvcId.DataPropertyName = "Id";
            this.gvcId.HeaderText = "ID";
            this.gvcId.Name = "gvcId";
            this.gvcId.ReadOnly = true;
            // 
            // gvcNo
            // 
            this.gvcNo.HeaderText = "No";
            this.gvcNo.Name = "gvcNo";
            this.gvcNo.ReadOnly = true;
            this.gvcNo.Width = 50;
            // 
            // gvcJoinDate
            // 
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.gvcJoinDate.DefaultCellStyle = dataGridViewCellStyle2;
            this.gvcJoinDate.HeaderText = "Join Date";
            this.gvcJoinDate.Name = "gvcJoinDate";
            this.gvcJoinDate.ReadOnly = true;
            this.gvcJoinDate.Width = 150;
            // 
            // gvcCustomerName
            // 
            this.gvcCustomerName.DataPropertyName = "CustomerName";
            this.gvcCustomerName.HeaderText = "Customer Name";
            this.gvcCustomerName.Name = "gvcCustomerName";
            this.gvcCustomerName.ReadOnly = true;
            this.gvcCustomerName.Width = 200;
            // 
            // gvcContactPerson
            // 
            this.gvcContactPerson.DataPropertyName = "ContactPerson";
            this.gvcContactPerson.HeaderText = "Contact Person";
            this.gvcContactPerson.Name = "gvcContactPerson";
            this.gvcContactPerson.ReadOnly = true;
            this.gvcContactPerson.Width = 200;
            // 
            // gvcContactNumber
            // 
            this.gvcContactNumber.DataPropertyName = "ContactNumber";
            this.gvcContactNumber.HeaderText = "Contact Number";
            this.gvcContactNumber.Name = "gvcContactNumber";
            this.gvcContactNumber.ReadOnly = true;
            this.gvcContactNumber.Width = 150;
            // 
            // gvcOutstandingBalance
            // 
            this.gvcOutstandingBalance.DataPropertyName = "OutstadningBalance";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.gvcOutstandingBalance.DefaultCellStyle = dataGridViewCellStyle3;
            this.gvcOutstandingBalance.HeaderText = "Outstanding Balance";
            this.gvcOutstandingBalance.Name = "gvcOutstandingBalance";
            this.gvcOutstandingBalance.ReadOnly = true;
            this.gvcOutstandingBalance.Width = 150;
            // 
            // frmSales_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.gvCustomerData);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtContactPerson);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnNew);
            this.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmSales_List";
            this.Text = "frmCustomer_List";
            this.Load += new System.EventHandler(this.frmSales_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvCustomerData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtContactPerson;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gvCustomerData;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvcId;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvcNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvcJoinDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvcCustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvcContactPerson;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvcContactNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvcOutstandingBalance;
    }
}