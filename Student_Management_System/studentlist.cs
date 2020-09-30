using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management_System
{
    public class studentlist
    {

        public void showlist(StudentListForm sform)
        {
            Student student = new Student();
            
            MySqlCommand command = new MySqlCommand("SELECT * FROM `student` ");
            sform.dataGridView1.ReadOnly = true;
            sform.dataGridView1.RowTemplate.Height = 60;
            sform.dataGridView1.DataSource = student.getStudents(command);
            sform.dataGridView1.AllowUserToAddRows = false;
        }
    }
}
