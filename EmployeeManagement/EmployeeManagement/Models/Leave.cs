using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public class Leave
    {
        public int LeaveId { get; set; }


        public string Type { get; set; }
        public string FromDate { get; set; }
        public string ToDate { get; set; }
        public string EmployeeName { get; set; }
    }
}
