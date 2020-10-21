using Student_Management_System.Model;
using Student_Management_System.ViewController;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management_System.Presenter
{

    class AddCoursePresenter
    {
        private IAddCourseFormView addCourseFormView;

        public AddCoursePresenter(IAddCourseFormView addCourseFormView)
        {
            this.addCourseFormView = addCourseFormView;
        }


        public bool onPressingAddingCourseButton(string CourseName, string CourseCode, string CourseCredit)
        {
            if (CourseName == "" || CourseCredit == "" || CourseCode == "")
                return false;
            else
            {

                IDatabaseTable databaseTable = new CourseTable(new Course(CourseName, CourseCode, CourseCredit));
                return databaseTable.SendData();
            }
        }






    }
}
