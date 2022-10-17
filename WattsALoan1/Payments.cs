using System;
using System.IO;
using System.Windows.Forms;

namespace WattsALoan1
{
    public partial class Payments : Form
    {
        public Payments()
        {
            InitializeComponent();
        }

        private void Payments_Load(object sender, EventArgs e)
        {
            string strFilename = "loans.xml";

            if (File.Exists(strFilename))
            {
                dsLoansAllocations.ReadXml(strFilename);
            }

            strFilename = "employees.xml";

            if (File.Exists(strFilename))
            {
                dsEmployees.ReadXml(strFilename);
            }

            strFilename = "payments.xml";

            if (File.Exists(strFilename))
            {
                dsPayments.ReadXml(strFilename);
            }
        }

        private void Payments_FormClosing(object sender, FormClosingEventArgs e)
        {
            dsPayments.WriteXml("payments.xml");
        }

        private void btnLoans_Click(object sender, EventArgs e)
        {
            LoansAllocations frmLoans = new LoansAllocations();
            frmLoans.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}