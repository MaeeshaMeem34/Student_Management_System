using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management_System.Model
{
    class Course
    {
        public Course(string courseNAme,string courseCode,string corseCredits)
        {
            this.CourseName = courseNAme;
            this.CourseCode = courseCode;
            this.CourseCredits = corseCredits;
        }
        public string CourseName { get;  }
        public string CourseCode { get; }
        public string CourseCredits { get; }

    }
}
