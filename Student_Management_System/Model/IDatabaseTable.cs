using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management_System.Model
{
    public interface IDatabaseTable
    {
       public bool SendData();
       public DataTable GetData();

        public bool UpdateInfo();
        public bool DeleteInfo(int id);
    }
}
