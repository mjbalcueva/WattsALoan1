namespace WattsALoan1
{
    partial class LoansAllocations
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dsLoansAllocations = new System.Data.DataSet();
            this.tblLoan = new System.Data.DataTable();
            this.colDateAllocated = new System.Data.DataColumn();
            this.colLoanNumber = new System.Data.DataColumn();
            this.colPreparedBy = new System.Data.DataColumn();
            this.colPreparedFor = new System.Data.DataColumn();
            this.colPrincipal = new System.Data.DataColumn();
            this.colInterestRate = new System.Data.DataColumn();
            this.colPeriods = new System.Data.DataColumn();
            this.colInterestEarned = new System.Data.DataColumn();
            this.colFutureValue = new System.Data.DataColumn();
            this.colMonthlyPayment = new System.Data.DataColumn();
            this.dsEmployees = new System.Data.DataSet();
            this.tblEmployee = new System.Data.DataTable();
            this.colEmployeeNumber = new System.Data.DataColumn();
            this.colFirstName = new System.Data.DataColumn();
            this.colLastName = new System.Data.DataColumn();
            this.colTitle = new System.Data.DataColumn();
            this.colHourlySalary = new System.Data.DataColumn();
            this.colEmployeeDetails = new System.Data.DataColumn();
            this.dsCustomers = new System.Data.DataSet();
            this.tblCustomer = new System.Data.DataTable();
            this.colAccountNumber = new System.Data.DataColumn();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.colEmailAddress = new System.Data.DataColumn();
            this.colPhoneNumber = new System.Data.DataColumn();
            this.colCustomerDetails = new System.Data.DataColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateAllocatedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loanNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preparedByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.preparedForDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.principalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.interestRateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.periodsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.interestEarnedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.futureValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monthlyPaymentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dsLoansAllocations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLoan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dsLoansAllocations
            // 
            this.dsLoansAllocations.DataSetName = "LoansAllocations";
            this.dsLoansAllocations.Tables.AddRange(new System.Data.DataTable[] {
            this.tblLoan});
            // 
            // tblLoan
            // 
            this.tblLoan.Columns.AddRange(new System.Data.DataColumn[] {
            this.colDateAllocated,
            this.colLoanNumber,
            this.colPreparedBy,
            this.colPreparedFor,
            this.colPrincipal,
            this.colInterestRate,
            this.colPeriods,
            this.colInterestEarned,
            this.colFutureValue,
            this.colMonthlyPayment});
            this.tblLoan.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "LoanNumber"}, false)});
            this.tblLoan.TableName = "Loan";
            // 
            // colDateAllocated
            // 
            this.colDateAllocated.AllowDBNull = false;
            this.colDateAllocated.ColumnName = "DateAllocated";
            this.colDateAllocated.DataType = typeof(System.DateTime);
            // 
            // colLoanNumber
            // 
            this.colLoanNumber.AllowDBNull = false;
            this.colLoanNumber.ColumnName = "LoanNumber";
            // 
            // colPreparedBy
            // 
            this.colPreparedBy.ColumnName = "PreparedBy";
            // 
            // colPreparedFor
            // 
            this.colPreparedFor.ColumnName = "PreparedFor";
            // 
            // colPrincipal
            // 
            this.colPrincipal.ColumnName = "Principal";
            this.colPrincipal.DataType = typeof(double);
            this.colPrincipal.DefaultValue = 0D;
            // 
            // colInterestRate
            // 
            this.colInterestRate.ColumnName = "InterestRate";
            this.colInterestRate.DataType = typeof(double);
            this.colInterestRate.DefaultValue = 8.75D;
            // 
            // colPeriods
            // 
            this.colPeriods.ColumnName = "Periods";
            this.colPeriods.DataType = typeof(double);
            this.colPeriods.DefaultValue = 36D;
            // 
            // colInterestEarned
            // 
            this.colInterestEarned.ColumnName = "InterestEarned";
            this.colInterestEarned.DataType = typeof(double);
            this.colInterestEarned.Expression = "Principal * (InterestRate / 100) * (Periods / 12)";
            this.colInterestEarned.ReadOnly = true;
            // 
            // colFutureValue
            // 
            this.colFutureValue.ColumnName = "FutureValue";
            this.colFutureValue.DataType = typeof(double);
            this.colFutureValue.Expression = "Principal + InterestEarned";
            this.colFutureValue.ReadOnly = true;
            // 
            // colMonthlyPayment
            // 
            this.colMonthlyPayment.ColumnName = "MonthlyPayment";
            this.colMonthlyPayment.DataType = typeof(double);
            this.colMonthlyPayment.Expression = "FutureValue / Periods";
            this.colMonthlyPayment.ReadOnly = true;
            // 
            // dsEmployees
            // 
            this.dsEmployees.DataSetName = "Employees";
            this.dsEmployees.Tables.AddRange(new System.Data.DataTable[] {
            this.tblEmployee});
            // 
            // tblEmployee
            // 
            this.tblEmployee.Columns.AddRange(new System.Data.DataColumn[] {
            this.colEmployeeNumber,
            this.colFirstName,
            this.colLastName,
            this.colTitle,
            this.colHourlySalary,
            this.colEmployeeDetails});
            this.tblEmployee.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "EmployeeNumber"}, false)});
            this.tblEmployee.TableName = "Employee";
            // 
            // colEmployeeNumber
            // 
            this.colEmployeeNumber.AllowDBNull = false;
            this.colEmployeeNumber.ColumnName = "EmployeeNumber";
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
            // colTitle
            // 
            this.colTitle.ColumnName = "Title";
            // 
            // colHourlySalary
            // 
            this.colHourlySalary.ColumnName = "HourlySalary";
            this.colHourlySalary.DataType = typeof(double);
            this.colHourlySalary.DefaultValue = 8.75D;
            // 
            // colEmployeeDetails
            // 
            this.colEmployeeDetails.ColumnName = "EmployeeDetails";
            this.colEmployeeDetails.Expression = "EmployeeNumber + \': \' +FirstName + \' \' + LastName";
            this.colEmployeeDetails.ReadOnly = true;
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
            this.dataColumn1,
            this.dataColumn2,
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
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "FirstName";
            // 
            // dataColumn2
            // 
            this.dataColumn2.AllowDBNull = false;
            this.dataColumn2.ColumnName = "LastName";
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
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateAllocatedDataGridViewTextBoxColumn,
            this.loanNumberDataGridViewTextBoxColumn,
            this.preparedByDataGridViewTextBoxColumn,
            this.preparedForDataGridViewTextBoxColumn,
            this.principalDataGridViewTextBoxColumn,
            this.interestRateDataGridViewTextBoxColumn,
            this.periodsDataGridViewTextBoxColumn,
            this.interestEarnedDataGridViewTextBoxColumn,
            this.futureValueDataGridViewTextBoxColumn,
            this.monthlyPaymentDataGridViewTextBoxColumn});
            this.dataGridView1.DataMember = "Loan";
            this.dataGridView1.DataSource = this.dsLoansAllocations;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1178, 379);
            this.dataGridView1.TabIndex = 0;
            // 
            // dateAllocatedDataGridViewTextBoxColumn
            // 
            this.dateAllocatedDataGridViewTextBoxColumn.DataPropertyName = "DateAllocated";
            dataGridViewCellStyle22.Format = "d";
            dataGridViewCellStyle22.NullValue = null;
            this.dateAllocatedDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle22;
            this.dateAllocatedDataGridViewTextBoxColumn.HeaderText = "Date Allocated";
            this.dateAllocatedDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateAllocatedDataGridViewTextBoxColumn.Name = "dateAllocatedDataGridViewTextBoxColumn";
            this.dateAllocatedDataGridViewTextBoxColumn.Width = 110;
            // 
            // loanNumberDataGridViewTextBoxColumn
            // 
            this.loanNumberDataGridViewTextBoxColumn.DataPropertyName = "LoanNumber";
            this.loanNumberDataGridViewTextBoxColumn.HeaderText = "Loan #";
            this.loanNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.loanNumberDataGridViewTextBoxColumn.Name = "loanNumberDataGridViewTextBoxColumn";
            this.loanNumberDataGridViewTextBoxColumn.Width = 110;
            // 
            // preparedByDataGridViewTextBoxColumn
            // 
            this.preparedByDataGridViewTextBoxColumn.DataPropertyName = "PreparedBy";
            this.preparedByDataGridViewTextBoxColumn.DataSource = this.dsEmployees;
            this.preparedByDataGridViewTextBoxColumn.DisplayMember = "Employee.EmployeeDetails";
            this.preparedByDataGridViewTextBoxColumn.HeaderText = "Prepared By";
            this.preparedByDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.preparedByDataGridViewTextBoxColumn.Name = "preparedByDataGridViewTextBoxColumn";
            this.preparedByDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.preparedByDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.preparedByDataGridViewTextBoxColumn.Width = 110;
            // 
            // preparedForDataGridViewTextBoxColumn
            // 
            this.preparedForDataGridViewTextBoxColumn.DataPropertyName = "PreparedFor";
            this.preparedForDataGridViewTextBoxColumn.DataSource = this.dsCustomers;
            this.preparedForDataGridViewTextBoxColumn.DisplayMember = "Customer.CustomerDetails";
            this.preparedForDataGridViewTextBoxColumn.HeaderText = "Prepared For";
            this.preparedForDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.preparedForDataGridViewTextBoxColumn.Name = "preparedForDataGridViewTextBoxColumn";
            this.preparedForDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.preparedForDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.preparedForDataGridViewTextBoxColumn.Width = 110;
            // 
            // principalDataGridViewTextBoxColumn
            // 
            this.principalDataGridViewTextBoxColumn.DataPropertyName = "Principal";
            dataGridViewCellStyle23.Format = "C2";
            dataGridViewCellStyle23.NullValue = null;
            this.principalDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle23;
            this.principalDataGridViewTextBoxColumn.HeaderText = "Principal";
            this.principalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.principalDataGridViewTextBoxColumn.Name = "principalDataGridViewTextBoxColumn";
            this.principalDataGridViewTextBoxColumn.Width = 110;
            // 
            // interestRateDataGridViewTextBoxColumn
            // 
            this.interestRateDataGridViewTextBoxColumn.DataPropertyName = "InterestRate";
            dataGridViewCellStyle24.Format = "N2";
            dataGridViewCellStyle24.NullValue = null;
            this.interestRateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle24;
            this.interestRateDataGridViewTextBoxColumn.HeaderText = "Rate (%)";
            this.interestRateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.interestRateDataGridViewTextBoxColumn.Name = "interestRateDataGridViewTextBoxColumn";
            this.interestRateDataGridViewTextBoxColumn.Width = 110;
            // 
            // periodsDataGridViewTextBoxColumn
            // 
            this.periodsDataGridViewTextBoxColumn.DataPropertyName = "Periods";
            dataGridViewCellStyle25.Format = "N2";
            dataGridViewCellStyle25.NullValue = null;
            this.periodsDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle25;
            this.periodsDataGridViewTextBoxColumn.HeaderText = "Prd (Months";
            this.periodsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.periodsDataGridViewTextBoxColumn.Name = "periodsDataGridViewTextBoxColumn";
            this.periodsDataGridViewTextBoxColumn.Width = 110;
            // 
            // interestEarnedDataGridViewTextBoxColumn
            // 
            this.interestEarnedDataGridViewTextBoxColumn.DataPropertyName = "InterestEarned";
            dataGridViewCellStyle26.Format = "C2";
            dataGridViewCellStyle26.NullValue = null;
            this.interestEarnedDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle26;
            this.interestEarnedDataGridViewTextBoxColumn.HeaderText = "Interest Earned";
            this.interestEarnedDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.interestEarnedDataGridViewTextBoxColumn.Name = "interestEarnedDataGridViewTextBoxColumn";
            this.interestEarnedDataGridViewTextBoxColumn.ReadOnly = true;
            this.interestEarnedDataGridViewTextBoxColumn.Width = 110;
            // 
            // futureValueDataGridViewTextBoxColumn
            // 
            this.futureValueDataGridViewTextBoxColumn.DataPropertyName = "FutureValue";
            dataGridViewCellStyle27.Format = "C2";
            dataGridViewCellStyle27.NullValue = null;
            this.futureValueDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle27;
            this.futureValueDataGridViewTextBoxColumn.HeaderText = "Future Value";
            this.futureValueDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.futureValueDataGridViewTextBoxColumn.Name = "futureValueDataGridViewTextBoxColumn";
            this.futureValueDataGridViewTextBoxColumn.ReadOnly = true;
            this.futureValueDataGridViewTextBoxColumn.Width = 110;
            // 
            // monthlyPaymentDataGridViewTextBoxColumn
            // 
            this.monthlyPaymentDataGridViewTextBoxColumn.DataPropertyName = "MonthlyPayment";
            dataGridViewCellStyle28.Format = "C2";
            dataGridViewCellStyle28.NullValue = null;
            this.monthlyPaymentDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle28;
            this.monthlyPaymentDataGridViewTextBoxColumn.HeaderText = "Pmt/Month";
            this.monthlyPaymentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.monthlyPaymentDataGridViewTextBoxColumn.Name = "monthlyPaymentDataGridViewTextBoxColumn";
            this.monthlyPaymentDataGridViewTextBoxColumn.ReadOnly = true;
            this.monthlyPaymentDataGridViewTextBoxColumn.Width = 110;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(29)))), ((int)(((byte)(72)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(63)))), ((int)(((byte)(94)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.btnClose.Location = new System.Drawing.Point(1115, 406);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 32);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // LoansAllocations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1202, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dataGridView1);
            this.Name = "LoansAllocations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoansAllocations";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoansAllocations_FormClosing);
            this.Load += new System.EventHandler(this.LoansAllocations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsLoansAllocations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLoan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Data.DataSet dsLoansAllocations;
        private System.Data.DataTable tblLoan;
        private System.Data.DataColumn colDateAllocated;
        private System.Data.DataColumn colLoanNumber;
        private System.Data.DataColumn colPreparedBy;
        private System.Data.DataColumn colPreparedFor;
        private System.Data.DataColumn colPrincipal;
        private System.Data.DataColumn colInterestRate;
        private System.Data.DataColumn colPeriods;
        private System.Data.DataColumn colInterestEarned;
        private System.Data.DataColumn colFutureValue;
        private System.Data.DataColumn colMonthlyPayment;
        private System.Data.DataSet dsEmployees;
        private System.Data.DataTable tblEmployee;
        private System.Data.DataColumn colEmployeeNumber;
        private System.Data.DataColumn colFirstName;
        private System.Data.DataColumn colLastName;
        private System.Data.DataColumn colTitle;
        private System.Data.DataColumn colHourlySalary;
        private System.Data.DataColumn colEmployeeDetails;
        private System.Data.DataSet dsCustomers;
        private System.Data.DataTable tblCustomer;
        private System.Data.DataColumn colAccountNumber;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataColumn colEmailAddress;
        private System.Data.DataColumn colPhoneNumber;
        private System.Data.DataColumn colCustomerDetails;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateAllocatedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loanNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn preparedByDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn preparedForDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn principalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn interestRateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn periodsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn interestEarnedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn futureValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn monthlyPaymentDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnClose;
    }
}