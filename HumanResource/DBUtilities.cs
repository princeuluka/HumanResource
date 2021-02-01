using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace HumanResource
{

    class DBUtilities
    {
        private string SERVER;
        private string DB;
        private string USERNAME;
        private string PASSWORD;

        private SqlConnection connection;
      

        public DBUtilities()
        {
            this.SERVER = "(LocalDb)\\MSSQLLocalDB";
            this.DB = "HumanResourceDB;";
            this.USERNAME = "sa;";
            this.PASSWORD = "0000;";

            connection = new SqlConnection(ConstructConnectionString());
        }
        public string DataLookUp(string column, string table, string criteria)
        {
            try
            { 
                string returnValue = "";
                string query = "SELECT " + column + " FROM " + table +
                        (criteria.Length > 0? " WHERE " + criteria : " ");

                DataTable dt = QueryTable(query);
                foreach (DataRow row in dt.Rows)
                {
                    returnValue = row[column].ToString();
                }
                return returnValue;
                
            }catch (Exception ex)
            {
                string msg = ex.Message;
                return "";
            }
        }
        public int RunSQLCommand(string query)
        {
            try
            {
                openConnection();
                int recordAffected;
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = query;
                    recordAffected = cmd.ExecuteNonQuery();
                    closeConnection();
                }
                return recordAffected;


            }catch (Exception ex)
            {
                string msg = ex.Message;
                return -1;
            }
     

        }
        public DataTable QueryTable(string query)
        {
            try
            {
                DataTable table = new DataTable();
               
                using (SqlCommand cmd = new SqlCommand())
                 {
                    openConnection();
                    cmd.Connection = connection;
                    cmd.CommandText = query;
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(table);
                    closeConnection();

                }
                return table;

            }catch (Exception ex)
            {
                 return null;


            }


           
        }

        private void closeConnection()
        {
            try
            {

                if ((connection != null) && (connection.State == System.Data.ConnectionState.Closed))
                {
                    connection.Close();
                }
            }
            catch (Exception)
            {
              
            }
        }
        private void openConnection()
        {
            try
            {

                if ((connection != null) && (connection.State == System.Data.ConnectionState.Closed))
                {
                    connection.Open();
                }
            }
            catch (Exception)
            {
              
            }
        }
        public bool isConnected()
        {
            try
            {
                
                if ((connection != null) && (connection.State == System.Data.ConnectionState.Closed))
                {
                    connection.Open();
                    connection.Close();
                    return true;
                }
                return false;

            }catch (Exception )
            {
                return false;
            }
        }
        private string ConstructConnectionString()
        {
            string returnVal = "Data Source=" + this.SERVER +
                                    "Initial Catalog=" + this.DB +
                                      "User Id=" + this.USERNAME +
                                      "Password=" +this.PASSWORD;
            return returnVal;
        }
    }


}
