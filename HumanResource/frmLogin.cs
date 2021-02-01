using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HumanResource
{

   
    public partial class frmLogin : Form
    {
        DBUtilities utilities;
        public frmLogin()
        {
            InitializeComponent();
            utilities = new DBUtilities();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void LoginProgram()
        {
           
            try
            {
                string username = txtUserName.Text;
                string password = txtPassword.Text;

                if (username.Trim().Equals("") || password.Trim().Equals(""))
                {
                    MessageBox.Show("Please enter the username and password.", "Human Resource",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    string id = utilities.DataLookUp("UserID", "tblUsers", " Username='" + username + 
                                                        "' AND UserPassword='"+ password +"'");

                    if (!id.Equals(""))
                    {
                        MessageBox.Show("Authorized. Welcome!!", "Human Resource",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        HumanResource_MainForm mainForm = new HumanResource_MainForm();
                        mainForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Username or Password ", "Human Resource",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginProgram();
        }
    }
}
