using System;
using System.Windows.Forms;

namespace WattsALoan1
{
    public partial class WattsALoan : Form
    {
        public WattsALoan()
        {
            InitializeComponent();
        }

        private void btnPayments_Click(object sender, EventArgs e)
        {
            Payments frmPayments = new Payments();
            frmPayments.ShowDialog();
        }

        private void btnAllocations_Click(object sender, EventArgs e)
        {
            LoansAllocations frmLoans = new LoansAllocations();
            frmLoans.ShowDialog();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            Customers frmClients = new Customers();
            frmClients.ShowDialog();
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            Employees frmStaff = new Employees();
            frmStaff.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}