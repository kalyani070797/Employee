using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Model.LeaveRequests
{
    public class LeaveRequestResponseModel
    {
        public int LeaveRequestId { get; set; }
        public int EmployeeDetailsId { get; set; }
        public int AdminId { get; set; }
        public string LeaveReason { get; set; }
        public int StatusId { get; set; } 
        public string LeaveType { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public int TotalLeaves { get; set; } // Assuming TotalLeaves is an integer
    }
}
