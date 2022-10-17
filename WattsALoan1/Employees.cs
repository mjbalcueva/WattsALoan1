using System;
using System.IO;
using System.Windows.Forms;

namespace WattsALoan1
{
    public partial class Employees : Form
    {
        public Employees()
        {
            InitializeComponent();
        }

        private void Employees_Load(object sender, EventArgs e)
        {
            string strFilename = "employees.xml";

            if (File.Exists(strFilename))
            {
                dsEmployees.ReadXml(strFilename);
            }
        }

        private void Employees_FormClosing(object sender, FormClosingEventArgs e)
        {
            dsEmployees.WriteXml("employees.xml");
        }
    }
}