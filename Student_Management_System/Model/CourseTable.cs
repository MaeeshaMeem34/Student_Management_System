using MySql.Data.MySqlClient;
using NUnit.Framework.Internal.Execution;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management_System.Model
{
    public class CourseTable : IDatabaseTable
    {
      
      

        DatabaseConnection db = new DatabaseConnection();

        private Course course;
        public CourseTable(Course course)
        {
            this.course = course;
        }

        public CourseTable()
        {

        }



        public bool SendData() 
        {

            MySqlCommand command = new MySqlCommand("INSERT INTO `course`( `courseName`, `courseCode`, `credit`) VALUES (@name,@code,@credit)", db.GetConnection);
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = course.CourseName;
            command.Parameters.Add("@code", MySqlDbType.VarChar).Value =course.CourseCode;
            command.Parameters.Add("@credit", MySqlDbType.VarChar).Value = course.CourseCredits;
            db.OpenConnection();



            if (command.ExecuteNonQuery() == 1)
            {
                db.CloseConnection();
                return true;
            }

            else
            {
                db.CloseConnection();
                return false;
            }
        }

        

        public DataTable GetData()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `course` ");
            command.Connection = db.GetConnection;

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;
        }

        public DataTable GetCourseById(int id)
        {
            

            MySqlCommand command = new MySqlCommand("SELECT  courseName, courseCode, credit FROM course WHERE id=@ID " );
            command.Connection = db.GetConnection;
            command.Parameters.Add("@ID", MySqlDbType.Int32).Value = id;

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;
        }





        public bool UpdateInfo()
        {

            MySqlCommand command = new MySqlCommand("UPDATE course SET courseName=@courseName,courseCode=@code,credit=@credit WHERE id= @ID", db.GetConnection);
            command.Parameters.Add("@ID", MySqlDbType.Int32).Value = course.Id;
            command.Parameters.Add("@courseName", MySqlDbType.VarChar).Value = course.CourseName;
            command.Parameters.Add("@code", MySqlDbType.VarChar).Value = course.CourseCode;
            command.Parameters.Add("@credit", MySqlDbType.VarChar).Value = course.CourseCredits;

            db.OpenConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                db.CloseConnection();
                return true;
            }

            else
            {
                db.CloseConnection();
                return false;
            }

        }

        public bool DeleteInfo(int id)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM course WHERE id= @SID", db.GetConnection);
            command.Parameters.Add("@SID", MySqlDbType.Int32).Value = id;
            db.OpenConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                db.CloseConnection();
                return true;
            }

            else
            {
                db.CloseConnection();
                return false;
            }


        }



    }
}
