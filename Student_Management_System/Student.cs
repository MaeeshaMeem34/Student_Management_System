using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Data;

namespace Student_Management_System
{
    public class Student
    {

        DatabaseConnection db = new DatabaseConnection();

        public bool InsertStudents(string fname, string lname,DateTime bdate, string gender, string phone, string address)
        {

            MySqlCommand command = new MySqlCommand("INSERT INTO `student`( `firstName`, `lasttName`, `birthdate`, `gender`, `phone`, `address`) VALUES (@fn,@ln,@date,@gender,@phone,@address)", db.GetConnection);
            command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@date", MySqlDbType.Date).Value = bdate;
            command.Parameters.Add("@gender", MySqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@phone", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@address", MySqlDbType.Text).Value = address;

            db.OpenConnection();

            if(command.ExecuteNonQuery() ==1)
            {
                db.CloseConnection();
                return true;
            }

            else
            {
                //db.CloseConnection();
                return false;
            }

        }


        //function to return a table of student data
        public DataTable getStudents(MySqlCommand command)
        {
            command.Connection = db.GetConnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;
        }
    }
}
