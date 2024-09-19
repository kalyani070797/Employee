using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Model.LeaveRequests
{
    public class LeaveRequestCountResponseModel
    {
        public List<EmployeeDetailsModel> EmployeeDetailsModel { get; set; }
        
       public StatusModelCount StatusModelCount { get;set; }

    }
    public class EmployeeDetailsModel
    {
        public int LeaveRequestId { get; set; }
        public int EmployeeDetailsId { get; set; }
        public int AdminId { get; set; }
        public string LeaveReason { get; set; }
        public int StatusId { get; set; } // StatusId is nullable
        public string LeaveType { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public int TotalLeaves { get; set; }
    }


public class StatusModelCount
    {
        public int Open { get; set; }
        public int Approved { get; set; }
        public int Rejected { get; set; }
}
    
}
