using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management_System
{
    public partial class StudentListForm : Form
    {
        public StudentListForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        Student student = new Student();

        private void StudentListForm_Load(object sender, EventArgs e)
        {
            // populate the datagrid with student data
            //showList();
            studentlist list = new studentlist();
            list.showlist(this);
            





        }

        /*public void showList()
        {

            MySqlCommand command = new MySqlCommand("SELECT * FROM `student` ");
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 60;
            dataGridView1.DataSource = student.getStudents(command);
            dataGridView1.AllowUserToAddRows = false;

        }
        */
    }
}
