using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Model.LeaveApprovals
{
    public class LeaveApprovalResponseModelByRequestId
    {
        public int LeaveApprovalId { get; set; }
        public int LeaveRequestId { get; set; }
        public DateTime LeaveApprovedDate { get; set; }
        public LeaveRequestModel LeaveRequestModel { get; set; }
    }
    public class LeaveRequestModel
    {
        public int EmployeeDetailsId { get; set; }
        public int AdminId { get; set; }
        public string LeaveReason { get; set; }
        public int StatusId { get; set; }
        public string LeaveType { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public int TotalLeaves { get; set; }
    }
}
