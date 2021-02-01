using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HumanResource
{
    public partial class formAddPosition : Form
    {
        DBUtilities utilities;
        public formAddPosition()
        {
            InitializeComponent();

            utilities = new DBUtilities();
        }

       

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtPositionName.Text.Trim().Equals(""))
            {
                MessageBox.Show("Please enter position name.", "Add Position",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string query = "INSERT into tblPosition(PositionName)" +
                    "VALUES('" + txtPositionName.Text + "')";

                int result = utilities.RunSQLCommand(query);

                if (result > 0)
                {
                    MessageBox.Show("New Position Name Added Successfully!", "Add Position",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                       txtPositionName.Text = "";
                }else
                {
                    MessageBox.Show("There is a problem saving a new Position", "Add Position",

                       MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
              
                }
            }

        }

      

      
    }
}
