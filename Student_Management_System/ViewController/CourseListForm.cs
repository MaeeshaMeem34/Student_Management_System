using MySql.Data.MySqlClient;
using Student_Management_System.ViewController;
using Student_Management_System.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Student_Management_System.Presenter;

namespace Student_Management_System
{
    public partial class CourseListForm : Form
    {

        
        public CourseListForm()
        {
            InitializeComponent();
        }

        private void CourseListForm_Load(object sender, EventArgs e)
        {
            showList();
            




        }



        
        public void showList()
        {
            DisplayCoursePresenter displayCoursePresenter = new DisplayCoursePresenter(this);
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 60;
            dataGridView1.DataSource = displayCoursePresenter.DisplayCourseList();
            dataGridView1.AllowUserToAddRows = false;

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            UpdateDeleteCourseForm updateDeleteCourse = new UpdateDeleteCourseForm();
            updateDeleteCourse.textBoxID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            updateDeleteCourse.textCourseName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            updateDeleteCourse.textCourseCode.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            updateDeleteCourse.textCourseCredit.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            updateDeleteCourse.Show();

        }

        private void refButton_Click(object sender, EventArgs e)
        {
            showList();
        }
    }
}
