using Employee.Core.LeaveRequests.Interface;
using Employee.Infrastructure.PracticeDbContext;
using Employee.Infrastructure.Tables;
using Employee.Model.LeaveApprovals;
using Employee.Model.LeaveRequests;
using Employee.Model.StatusModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Core.LeaveRequests.Implementation
{
    public class LeaveRequestCreator(EmployeeDbContext employeeDbContext) : ILeaveRequestCreator
    {
        public void CreateLeaveRequest(LeaveRequestRequestModel leaveRequestRequest)
        {
            var createLeaveRequest = new LeaveRequest()
            {
                EmployeeDetailsId = leaveRequestRequest.EmployeeDetailsId,
                AdminId = leaveRequestRequest.AdminId,
                LeaveReason = leaveRequestRequest.LeaveReason,
                StatusId = (int)EnumStatusName.Open,
                LeaveType = leaveRequestRequest.LeaveType,
                FromDate = leaveRequestRequest.FromDate,
                ToDate = leaveRequestRequest.ToDate,
                TotalLeaves = (leaveRequestRequest.ToDate - leaveRequestRequest.FromDate).Days + 1
            };
            employeeDbContext.LeaveRequest.Add(createLeaveRequest);
            employeeDbContext.SaveChanges();
        }
    }
}
