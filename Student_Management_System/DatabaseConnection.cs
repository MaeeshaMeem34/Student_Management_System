using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace Student_Management_System
{
    class DatabaseConnection
    {
        public MySqlConnection GetConnection { get; } = new MySqlConnection("datasource=127.0.0.1 ;port=3306;username=root;password=;database=studentmanagementsysdb");

        public void OpenConnection()
        {
            if(GetConnection.State== ConnectionState.Closed)
            {
                GetConnection.Open();
            }
        }

        public void CloseConnection()
        {
            if (GetConnection.State == ConnectionState.Open)
            {
                GetConnection.Close();
            }
        }


        


    }
}
