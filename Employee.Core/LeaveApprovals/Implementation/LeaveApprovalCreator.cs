using Employee.Core.LeaveApprovals.Interface;
using Employee.Infrastructure.PracticeDbContext;
using Employee.Infrastructure.Tables;
using Employee.Model.LeaveApprovals;
using Employee.Model.StatusModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Core.LeaveApprovals.Implementation
{
    public class LeaveApprovalCreator(EmployeeDbContext employeeDbContext) : ILeaveApprovalCreator
    {
        public string CreateLeaveApproval(int leaveRequestId, int statusId)
        {
            var checkLeaveRequest = employeeDbContext.LeaveRequest
                .First(i => i.LeaveRequestId == leaveRequestId);
            var leaveApproval = new LeaveApproval()
            {
                LeaveRequestId = leaveRequestId,
                LeaveApprovedDate = DateTime.Now,
            };
            employeeDbContext.LeaveApproval.Add(leaveApproval);
            checkLeaveRequest.StatusId = statusId;
            employeeDbContext.LeaveRequest.Update(checkLeaveRequest);
            employeeDbContext.SaveChanges();
            if (checkLeaveRequest.StatusId == (int)EnumStatusName.Approved)
            {
                return "Leave Approved";
            }
            else  
                return "Leave Rejected";

        }
    }
}
