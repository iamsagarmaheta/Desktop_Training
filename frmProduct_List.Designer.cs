namespace GSTBilling
{
    partial class frmProduct_List
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gvProductData = new System.Windows.Forms.DataGridView();
            this.gvcId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvcNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvcEntryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvcCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvcProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvcSalesRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gvProductData)).BeginInit();
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
            this.label1.Size = new System.Drawing.Size(1256, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product List";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNew
            // 
            this.btnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNew.Font = new System.Drawing.Font("Open Sans", 14F);
            this.btnNew.Location = new System.Drawing.Point(802, 133);
            this.btnNew.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(138, 46);
            this.btnNew.TabIndex = 4;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExport.Font = new System.Drawing.Font("Open Sans", 14F);
            this.btnExport.Location = new System.Drawing.Point(1102, 74);
            this.btnExport.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(138, 46);
            this.btnExport.TabIndex = 7;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Font = new System.Drawing.Font("Open Sans", 14F);
            this.btnSearch.Location = new System.Drawing.Point(802, 74);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(288, 46);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Font = new System.Drawing.Font("Open Sans", 14F);
            this.btnEdit.Location = new System.Drawing.Point(952, 133);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(138, 46);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Font = new System.Drawing.Font("Open Sans", 14F);
            this.btnDelete.Location = new System.Drawing.Point(1102, 133);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(138, 46);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "Category Name";
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Location = new System.Drawing.Point(184, 81);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(401, 33);
            this.txtCategoryName.TabIndex = 1;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(184, 123);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(401, 33);
            this.txtProductName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 26);
            this.label3.TabIndex = 8;
            this.label3.Text = "Product Name";
            // 
            // gvProductData
            // 
            this.gvProductData.AllowUserToAddRows = false;
            this.gvProductData.AllowUserToDeleteRows = false;
            this.gvProductData.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(214)))), ((int)(((byte)(229)))));
            this.gvProductData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gvProductData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvProductData.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gvProductData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvProductData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gvcId,
            this.gvcNo,
            this.gvcEntryDate,
            this.gvcCategory,
            this.gvcProductName,
            this.gvcSalesRate});
            this.gvProductData.Location = new System.Drawing.Point(12, 190);
            this.gvProductData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gvProductData.MultiSelect = false;
            this.gvProductData.Name = "gvProductData";
            this.gvProductData.ReadOnly = true;
            this.gvProductData.RowHeadersVisible = false;
            this.gvProductData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.gvProductData.RowTemplate.Height = 40;
            this.gvProductData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvProductData.Size = new System.Drawing.Size(1232, 422);
            this.gvProductData.TabIndex = 8;
            // 
            // gvcId
            // 
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
            // gvcEntryDate
            // 
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.gvcEntryDate.DefaultCellStyle = dataGridViewCellStyle2;
            this.gvcEntryDate.HeaderText = "Entry Date";
            this.gvcEntryDate.Name = "gvcEntryDate";
            this.gvcEntryDate.ReadOnly = true;
            this.gvcEntryDate.Width = 120;
            // 
            // gvcCategory
            // 
            this.gvcCategory.HeaderText = "Category";
            this.gvcCategory.Name = "gvcCategory";
            this.gvcCategory.ReadOnly = true;
            this.gvcCategory.Width = 200;
            // 
            // gvcProductName
            // 
            this.gvcProductName.HeaderText = "Product Name";
            this.gvcProductName.Name = "gvcProductName";
            this.gvcProductName.ReadOnly = true;
            this.gvcProductName.Width = 300;
            // 
            // gvcSalesRate
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.gvcSalesRate.DefaultCellStyle = dataGridViewCellStyle3;
            this.gvcSalesRate.HeaderText = "Sales Rate";
            this.gvcSalesRate.Name = "gvcSalesRate";
            this.gvcSalesRate.ReadOnly = true;
            this.gvcSalesRate.Width = 150;
            // 
            // frmProduct_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1256, 625);
            this.Controls.Add(this.gvProductData);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCategoryName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Open Sans", 14F);
            this.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.Name = "frmProduct_List";
            this.Text = "frmProduct_List";
            ((System.ComponentModel.ISupportInitialize)(this.gvProductData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView gvProductData;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvcId;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvcNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvcEntryDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvcCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvcProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvcSalesRate;
    }
}