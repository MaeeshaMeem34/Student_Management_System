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
    public partial class AddStudentsForm : Form
    {
        public AddStudentsForm()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonCancelstd_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonAddStd_Click(object sender, EventArgs e)
        {
            //add new student

            Student student = new Student();
            string fname = textBoxFname.Text;
            string lname = textBoxLname.Text;
            DateTime bdate = dateTimePickerBdate.Value;
            string phone = textBoxPhone.Text;
            string address = textBoxAddress.Text;
            string gender = "Male";

            if (radioButtonFemale.Checked)
            {
                gender = "Female";
            }

            // check age of student

            int born_year = dateTimePickerBdate.Value.Year;
            int this_year = DateTime.Now.Year;

            if (((this_year - born_year) <10) ||  ((this_year - born_year) > 100))
            {
                MessageBox.Show("Student age must be between 10 and 100", "Invalid birthdate", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else if (verify())
            {
                if (student.InsertStudents(fname, lname, bdate, gender, phone, address))
                {
                    MessageBox.Show("New Student Added!", "Add student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Adding failed!", "Add student", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }

            else
            {
                MessageBox.Show("No field can be empty!", "Add student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }





        }

        //function to verify data
        bool verify()
        {
            if((textBoxFname.Text.Trim()=="")||
                (textBoxLname.Text.Trim() == "") ||
                (textBoxPhone.Text.Trim() == "") ||
                (textBoxAddress.Text.Trim() == "" ))
            {
                return false;
            }
            else
            {
                return true;
            }


        }




    }
}
