using NUnit.Framework.Internal.Execution;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management_System.Model
{
    class CourseTable : IDatabaseTable
    {
        private Course course;
        public CourseTable(Course course)
        {
            this.course = course;
        }
        public DataTable GetData()
        {
            DataTable table=new DataTable();
            //retrive korar method ta bujhi nai,but data table er value jodi direct form a boshano jai then ei method thik ache
            return table;
        }

        public bool SendData()
        {
            //try cacth er vitore thakbe oi inserting process ta ,exception na hole true patha other wize false pathabe
            //ami cours class pathai disi get diye diye insert koraite parbi
            return true;
        }
    }
}
