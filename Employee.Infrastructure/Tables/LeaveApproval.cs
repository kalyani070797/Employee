using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Infrastructure.Tables
{
    public class LeaveApproval
    {
        public int LeaveApprovalId { get; set; }
        //public int AdminId { get; set; }
        //public int StatusId { get; set; }
        public int LeaveRequestId { get; set; }
        public DateTime LeaveApprovedDate { get; set; }
        public LeaveRequest LeaveRequest { get; set; }
        //public Admin Admin { get; set; }
        //public Status Status { get; set; }

    }
}
