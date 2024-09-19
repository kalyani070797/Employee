using Employee.Core.LeaveApprovals.Interface;
using Employee.Infrastructure.PracticeDbContext;
using Employee.Model.LeaveApprovals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Core.LeaveApprovals.Implementation
{
    public class LeaveApprovalInformationById(EmployeeDbContext employeeDbContext) : ILeaveApprovalInformationById
    {
        public LeaveApprovalResponseModel GellAllLeaveApprovalById(int leaveApprovalId)
        {
            var gellAllLeaveApprovalById = employeeDbContext.LeaveApproval
                .Where(i => i.LeaveApprovalId == leaveApprovalId)
                .Select(i => new LeaveApprovalResponseModel
                {
                    LeaveApprovalId = i.LeaveApprovalId,
                    LeaveRequestId = i.LeaveRequestId,
                    LeaveApprovedDate = i.LeaveApprovedDate,
                }).FirstOrDefault();
            return gellAllLeaveApprovalById;
        }
    }
}
