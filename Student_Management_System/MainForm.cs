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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            CustomizeDesign();
        }

        private void CustomizeDesign()
        {
            panelStudentSubMenu.Visible = false;
            panelCourseSubMenu.Visible = false;
        }

        private void HideSubMenu()
        {
            if(panelStudentSubMenu.Visible== true)
            {
                panelStudentSubMenu.Visible = false;
            }
            if (panelCourseSubMenu.Visible == true)
            {
                panelCourseSubMenu.Visible = false;
            }
        }

        private void showSubMenu(Panel submenu)
        {

            if (submenu.Visible == false)
            {
                HideSubMenu();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;


        }

        private void buttonStudent_Click(object sender, EventArgs e)
        {
            showSubMenu(panelStudentSubMenu);

        }

        private void buttonStudentAdd_Click(object sender, EventArgs e)
        {
            //AddStudentsForm studentsForm = new AddStudentsForm();
            //studentsForm.Show(this);
            OpenChildForm(new AddStudentsForm());
            HideSubMenu();
        }

        private Form activeForm = null;
        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildform.Controls.Add(childForm);
            panelChildform.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            
        }

        private void buttonStudentList_Click(object sender, EventArgs e)
        {
            OpenChildForm(new StudentListForm());
            HideSubMenu();

        }
    }
}
