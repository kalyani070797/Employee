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
    public class LeaveApprovalInformation(EmployeeDbContext employeeDbContext) : ILeaveApprovalInformation
    {
        public List<LeaveApprovalResponseModel> GellAllLeaveApproval()
        {
            var gellAllLeaveApproval = employeeDbContext.LeaveApproval
                .Select(x => new LeaveApprovalResponseModel
                {
                    LeaveApprovalId = x.LeaveApprovalId,
                    LeaveRequestId = x.LeaveRequestId,
                    LeaveApprovedDate = x.LeaveApprovedDate,
                }).ToList();
            return gellAllLeaveApproval;
        }
    }
}
