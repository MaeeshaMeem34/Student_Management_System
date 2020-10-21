using Student_Management_System.ViewController;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management_System.Model
{
    public class Course
    {


        public string CourseName { get; set; }
        public string CourseCode { get; set; }
        public string CourseCredits { get; set; }


        public int Id { get; }

        public Course(string courseNAme,string courseCode,string corseCredits)
        {
            CourseName = courseNAme;
            CourseCode = courseCode;
            CourseCredits = corseCredits;

        }

        public Course(int id,string courseNAme, string courseCode, string corseCredits)
        {
            Id = id;
            CourseName = courseNAme;
            CourseCode = courseCode;
            CourseCredits = corseCredits;

        }













    }
}
