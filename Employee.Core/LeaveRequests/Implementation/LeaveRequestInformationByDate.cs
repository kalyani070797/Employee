using Employee.Infrastructure.PracticeDbContext;
using Employee.Model.LeaveRequests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Core.LeaveRequests.Implementation
{
    public class LeaveRequestInformationByDate(EmployeeDbContext employeeDbContext) : ILeaveRequestInformationByDate
    {
        public List<LeaveRequestResponseModel> GetLeaveRequestByDate(DateTime fromDate)
        {
            var getLeaveRequestByDate = employeeDbContext.LeaveRequest
                .Where(i => i.FromDate >= fromDate && i.ToDate <= DateTime.Now)
                .Select(i => new LeaveRequestResponseModel
                {
                    LeaveRequestId = i.LeaveRequestId,
                    EmployeeDetailsId = i.EmployeeDetailsId,
                    AdminId = i.AdminId,
                    LeaveReason = i.LeaveReason,
                    StatusId = i.StatusId,
                    LeaveType = i.LeaveType,
                    FromDate = fromDate,
                    ToDate = DateTime.Now,
                    TotalLeaves = i.TotalLeaves,
                }).ToList();
            return getLeaveRequestByDate;
        }
    }
}
