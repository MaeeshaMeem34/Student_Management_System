using Student_Management_System.Controller;
using Student_Management_System.ViewController;
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
    public partial class AddCourseForm : Form,IAddCourseFormView
    {
        public AddCourseForm()
        {
            InitializeComponent();
        }

        private void AddCourse_Load(object sender, EventArgs e)
        {

        }

        private void buttonAdd_click(object sender, EventArgs e)
        {
            AddCoursePresenter addCoursePresenter = new AddCoursePresenter(this);
            
            if (addCoursePresenter.onPressingAddingCourseButton(textCourseName.Text,textCourseCode.Text,textCourseCredit.Text) == false)
             MessageBox.Show("Something went wrong");

        }

        private void buttonCancel_click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
