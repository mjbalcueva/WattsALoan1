namespace WattsALoan1
{
    partial class Customers
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
            this.dsCustomers = new System.Data.DataSet();
            this.tblCustomer = new System.Data.DataTable();
            this.colAccountNumber = new System.Data.DataColumn();
            this.colFirstName = new System.Data.DataColumn();
            this.colLastName = new System.Data.DataColumn();
            this.colEmailAddress = new System.Data.DataColumn();
            this.colPhoneNumber = new System.Data.DataColumn();
            this.colCustomerDetails = new System.Data.DataColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.accountNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerDetailsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dsCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dsCustomers
            // 
            this.dsCustomers.DataSetName = "Customers";
            this.dsCustomers.Tables.AddRange(new System.Data.DataTable[] {
            this.tblCustomer});
            // 
            // tblCustomer
            // 
            this.tblCustomer.Columns.AddRange(new System.Data.DataColumn[] {
            this.colAccountNumber,
            this.colFirstName,
            this.colLastName,
            this.colEmailAddress,
            this.colPhoneNumber,
            this.colCustomerDetails});
            this.tblCustomer.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "AccountNumber"}, false)});
            this.tblCustomer.TableName = "Customer";
            // 
            // colAccountNumber
            // 
            this.colAccountNumber.AllowDBNull = false;
            this.colAccountNumber.ColumnName = "AccountNumber";
            // 
            // colFirstName
            // 
            this.colFirstName.ColumnName = "FirstName";
            // 
            // colLastName
            // 
            this.colLastName.AllowDBNull = false;
            this.colLastName.ColumnName = "LastName";
            // 
            // colEmailAddress
            // 
            this.colEmailAddress.ColumnName = "EmailAddress";
            // 
            // colPhoneNumber
            // 
            this.colPhoneNumber.ColumnName = "PhoneNumber";
            // 
            // colCustomerDetails
            // 
            this.colCustomerDetails.ColumnName = "CustomerDetails";
            this.colCustomerDetails.Expression = "AccountNumber + \': \' + FirstName + \' \' + LastName";
            this.colCustomerDetails.ReadOnly = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.accountNumberDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.emailAddressDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.customerDetailsDataGridViewTextBoxColumn});
            this.dataGridView1.DataMember = "Customer";
            this.dataGridView1.DataSource = this.dsCustomers;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 379);
            this.dataGridView1.TabIndex = 0;
            // 
            // accountNumberDataGridViewTextBoxColumn
            // 
            this.accountNumberDataGridViewTextBoxColumn.DataPropertyName = "AccountNumber";
            this.accountNumberDataGridViewTextBoxColumn.HeaderText = "Account #";
            this.accountNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.accountNumberDataGridViewTextBoxColumn.Name = "accountNumberDataGridViewTextBoxColumn";
            this.accountNumberDataGridViewTextBoxColumn.Width = 110;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.firstNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.Width = 110;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "Last Name";
            this.lastNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.Width = 110;
            // 
            // emailAddressDataGridViewTextBoxColumn
            // 
            this.emailAddressDataGridViewTextBoxColumn.DataPropertyName = "EmailAddress";
            this.emailAddressDataGridViewTextBoxColumn.HeaderText = "Email Address";
            this.emailAddressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailAddressDataGridViewTextBoxColumn.Name = "emailAddressDataGridViewTextBoxColumn";
            this.emailAddressDataGridViewTextBoxColumn.Width = 110;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "Phone #";
            this.phoneNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            this.phoneNumberDataGridViewTextBoxColumn.Width = 110;
            // 
            // customerDetailsDataGridViewTextBoxColumn
            // 
            this.customerDetailsDataGridViewTextBoxColumn.DataPropertyName = "CustomerDetails";
            this.customerDetailsDataGridViewTextBoxColumn.HeaderText = "Customer Details";
            this.customerDetailsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customerDetailsDataGridViewTextBoxColumn.Name = "customerDetailsDataGridViewTextBoxColumn";
            this.customerDetailsDataGridViewTextBoxColumn.ReadOnly = true;
            this.customerDetailsDataGridViewTextBoxColumn.Width = 150;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(713, 406);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 32);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Customers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customers";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Customers_FormClosing);
            this.Load += new System.EventHandler(this.Customers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Data.DataSet dsCustomers;
        private System.Data.DataTable tblCustomer;
        private System.Data.DataColumn colAccountNumber;
        private System.Data.DataColumn colFirstName;
        private System.Data.DataColumn colLastName;
        private System.Data.DataColumn colEmailAddress;
        private System.Data.DataColumn colPhoneNumber;
        private System.Data.DataColumn colCustomerDetails;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerDetailsDataGridViewTextBoxColumn;
    }
}