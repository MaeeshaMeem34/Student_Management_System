using MySqlX.XDevAPI.Relational;
using Student_Management_System.Model;
using Student_Management_System.ViewController;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management_System.Presenter
{
    class DisplayCoursePresenter
    {
        
        private CourseListForm courseListForm;
        private UpdateDeleteCourseForm upDelForm;
        public DisplayCoursePresenter(CourseListForm courseListForm)
        {
            this.courseListForm = courseListForm;
        }

        public DisplayCoursePresenter(UpdateDeleteCourseForm upDelForm)
        {
            this.upDelForm = upDelForm;
        }





        public DataTable DisplayCourseList()
        {
            CourseTable courseInfo = new CourseTable();
            return courseInfo.GetData();
            






        }

        public DataTable DisplayCourseById(int id)
        {
            CourseTable courseInfo = new CourseTable();
            return courseInfo.GetCourseById(id);







        }

    }
}
