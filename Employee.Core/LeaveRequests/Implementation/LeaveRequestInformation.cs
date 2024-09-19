using Employee.Core.LeaveRequests.Interface;
using Employee.Infrastructure.PracticeDbContext;
using Employee.Model.LeaveRequests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Core.LeaveRequests.Implementation
{
    public class LeaveRequestInformation(EmployeeDbContext employeeDbContext) : ILeaveRequestInformation
    {
        public List<LeaveRequestResponseModel> GetAllLeaveRequest()
        {
            var getAllLeaveRequestInfo = employeeDbContext.LeaveRequest
                .Select(i => new LeaveRequestResponseModel
                {
                    LeaveRequestId = i.LeaveRequestId,
                    EmployeeDetailsId = i.EmployeeDetailsId,
                    AdminId = i.AdminId,
                    LeaveReason = i.LeaveReason,
                    StatusId = i.StatusId,
                    LeaveType = i.LeaveType,
                    FromDate = i.FromDate,
                    ToDate = i.ToDate,
                    TotalLeaves = i.TotalLeaves,
                }).ToList();
            return getAllLeaveRequestInfo;
        }       
    }
}
