 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HumanResource
{
    public partial class frmShowEmployees : Form
    {
        DBUtilities dbUtilities;

        public static bool isNewEmployeeAdded = false;
        public frmShowEmployees()
        {
            InitializeComponent();
            LoadEmployeeData();
           
        }
        private void LoadEmployeeData()
        {
            listEmployees.Items.Clear();
            
            dbUtilities = new DBUtilities();
            DataTable dt = dbUtilities.QueryTable("SELECT e.*,p.PositionName "+ 
                                                    "FROM tblEmployees e INNER JOIN tblPosition p "+
                                                    "ON e.PositionID = p.PositionID " +
                                                    "ORDER BY ID; ");

            foreach (DataRow row in dt.Rows )
            {
                ListViewItem item = new ListViewItem(row["ID"].ToString());
                item.SubItems.Add(row["FirstName"].ToString());
                item.SubItems.Add(row["LastName"].ToString());
                item.SubItems.Add(row["MiddleName"].ToString());
                item.SubItems.Add(row["PositionName"].ToString());
                item.SubItems.Add(row["Gender"].ToString());
                string bdate = Convert.ToDateTime(row["BDate"].ToString()).ToString("MMM dd, yyyy");
                item.SubItems.Add(bdate);
                item.SubItems.Add(row["HomeAddress"].ToString());
                item.SubItems.Add(row["TelNo"].ToString());
                item.SubItems.Add(row["MobileNo"].ToString());
                item.SubItems.Add(row["EmailAddress"].ToString());


                listEmployees.Items.Add(item);
            }


        }

     

        private void tmrUpdate_Tick(object sender, EventArgs e)
        {
            if (isNewEmployeeAdded)
            {
                LoadEmployeeData();
                isNewEmployeeAdded = false; 
            }
        }
    }
}
