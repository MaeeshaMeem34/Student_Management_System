using MySql.Data.MySqlClient;
using Student_Management_System.Model;
using Student_Management_System.Presenter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management_System.ViewController
{
    public partial class UpdateDeleteCourseForm : Form
    {

        //private Course course;
        public UpdateDeleteCourseForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void UpdateDeleteCourseForm_Load(object sender, EventArgs e)
        {

        }
        

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            
           UpdateDeleteCoursePresenter updateCoursePresenter = new UpdateDeleteCoursePresenter(this);
           if (updateCoursePresenter.updateCourse(Convert.ToInt32(textBoxID.Text), textCourseName.Text, textCourseCode.Text, textCourseCredit.Text) )
                MessageBox.Show("Course info Updated!");
            else
            {
                MessageBox.Show("Course info not updated!");
            }
            
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            UpdateDeleteCoursePresenter updateCoursePresenter = new UpdateDeleteCoursePresenter(this);
            int id = Convert.ToInt32(textBoxID.Text);

            if (MessageBox.Show("Are you sure you want to delete this student?", "Delete student", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) ;
            {
                if (updateCoursePresenter.DeleteInfo(id))
                {
                    MessageBox.Show("Student deleted");
                    //clear fields
                    textBoxID.Text = "";
                    textCourseName.Text = "";
                    textCourseCode.Text = "";
                    textCourseCredit.Text = "";



                }
                else
                {
                    MessageBox.Show("Student is not deleted");

                }
            }
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBoxID.Text);

          
            //search student by id
            
            DisplayCoursePresenter displayPresenter = new DisplayCoursePresenter(this);

            DataTable table = displayPresenter.DisplayCourseById(id);         

            if (table.Rows.Count > 0)
            {
                textCourseName.Text = table.Rows[0]["courseName"].ToString();
                textCourseCode.Text = table.Rows[0]["courseCode"].ToString();
                textCourseCredit.Text = table.Rows[0]["credit"].ToString();

            }
            else
            {
                MessageBox.Show("This course does not exist!");
            }
        }
    }
}
