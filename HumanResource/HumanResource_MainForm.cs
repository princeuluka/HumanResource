using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HumanResource
{
    public partial class HumanResource_MainForm : Form
    {

        public HumanResource_MainForm()
        {
            InitializeComponent();
        }

        private void mnuShowAllEmployees_Click(object sender, EventArgs e)
        {
            frmShowEmployees showEmployees = new frmShowEmployees();
            showEmployees.MdiParent = this;
            showEmployees.WindowState = FormWindowState.Normal;
            showEmployees.Show();

        }

        private void munAddEmployee_Click(object sender, EventArgs e)
        {
            frmAddEmployee addEmployee = new frmAddEmployee();
            addEmployee.MdiParent = this;
            addEmployee.WindowState = FormWindowState.Normal;
            addEmployee.Show();
        }

        private void mnuAddPosition_Click(object sender, EventArgs e)
        {
            formAddPosition addPosition = new formAddPosition();
            addPosition.MdiParent = this;
            addPosition.WindowState = FormWindowState.Normal;
            addPosition.Show();
        }
    }
}
