using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Model.LeaveApprovals
{
    public class LeaveApprovalResponseModel
    {
        public int LeaveApprovalId { get; set; }
        public int LeaveRequestId { get; set; }
        public DateTime LeaveApprovedDate { get; set; }
    }
}
