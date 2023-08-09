using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class PerfomanceBO
    {
        public int PerfomanceID { get; set; }
        public int EmployeeID { get; set; }
        public DateTime ReviewDate { get; set; }
        public string Goal { get; set; }
        public string Review { get; set; }
    }
}
