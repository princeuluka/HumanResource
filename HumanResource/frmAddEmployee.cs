using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HumanResource
{
    public partial class frmAddEmployee : Form
    {

        DBUtilities utilities;
        public frmAddEmployee()
        {
            InitializeComponent();
            utilities = new DBUtilities();
            loadPositions();
        }
        private void loadPositions()
        {
            try
            {

                cmbPosition.Items.Clear();
                DataTable positions = utilities.QueryTable("SELECT PositionName From tblPosition");
                foreach (DataRow row in positions.Rows)
                {
                    cmbPosition.Items.Add(row["PositionName"].ToString());
                }
            }catch(Exception ex)
            {

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string insertQuery = "INSERT INTO tblEmployees(FirstName, MiddleName, LastName, PositionID, " +
                                 "BDate, Gender, HomeAddress, TelNo, MobileNo, EmailAddress)" +
                                 "VALUES('" + txtFirstName.Text + "','" + txtMiddleName.Text + "'," + 
                                 "'" + txtLastName.Text + "','" + getPositionID(cmbPosition.Text)+ "',"+
                                 "'" + Convert.ToDateTime(dtBDate.Text).ToString("yyyy/MM/dd") + "'," +
                                 "'" + cmbGender.Text+ "','" + txtAddress.Text+ "','" + txtTelephoneNo.Text + "'," +
                                 "'" + txtMobileNo.Text+"', '" + txtEmailAddress.Text +"'); ";

            DialogResult res = MessageBox.Show("Are you sure you want to save a new employee?",
                "Save Employee", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {
              int result =  utilities.RunSQLCommand(insertQuery);
                if (result > 0)
                {
                    MessageBox.Show("New Employee added.", "Add Employee",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmShowEmployees.isNewEmployeeAdded = true;
                    this.Close();
                }else
                {
                    MessageBox.Show("There is a problem saving a new employee.", "Add Employee",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private int getPositionID(string position)
        {
            try
            {
                int positionID = Convert.ToInt32(utilities.DataLookUp("PositionID", "tblPosition",
                    "PositionName='" + position +"'"));
                return positionID;

            }catch (Exception ex)
            {
                string msg = ex.Message;;
                return 0;
            }
        }

      
    }
}
