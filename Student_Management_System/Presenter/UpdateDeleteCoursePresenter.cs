using Student_Management_System.Model;
using Student_Management_System.ViewController;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management_System.Presenter
{
    public class UpdateDeleteCoursePresenter
    {
       

        private UpdateDeleteCourseForm updateDeleteform;
        public UpdateDeleteCoursePresenter(UpdateDeleteCourseForm updateDeleteform)
        {
            this.updateDeleteform = updateDeleteform;
       }



     

        public bool updateCourse(int id, string CourseName, string CourseCode, string CourseCredit)
        {

            if ( CourseName == " " || CourseCode == " " || CourseCredit == " ")
                return false;
           else
            {

                CourseTable databaseTable = new CourseTable(new Course(id,CourseName, CourseCode, CourseCredit));
                 
                return databaseTable.UpdateInfo();

            }
        }

        public bool DeleteInfo(int id)
        {
            CourseTable databaseTable = new CourseTable();

            return databaseTable.DeleteInfo(id);

        }
    }
}
