using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class AttendenceBO
    {
        public int AttendenceID { get; set; }
        public int EmployeeID { get; set; }
        public DateTime Date { get; set; }
        public string Reason { get; set; }
    }
}
