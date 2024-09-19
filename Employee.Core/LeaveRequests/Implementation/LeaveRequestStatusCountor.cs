using Employee.Core.LeaveRequests.Interface;
using Employee.Infrastructure.PracticeDbContext;
using Employee.Infrastructure.Tables;
using Employee.Model.LeaveRequests;
using Employee.Model.StatusModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Core.LeaveRequests.Implementation
{
    public class LeaveRequestStatusCountor(EmployeeDbContext employeeDbContext) : ILeaveRequestStatusCountor
    {
        public LeaveRequestCountResponseModel StatusCount()
        {
            var leaveCount = employeeDbContext.LeaveRequest.ToList();
            var OpenCount = leaveCount
                 .Count(o => o.StatusId == (int)EnumStatusName.Open);
            var ApprovedCount = leaveCount
                .Count(a => a.StatusId == (int)EnumStatusName.Approved);
            var RejectedCount = leaveCount
                .Count(r => r.StatusId == (int)EnumStatusName.Rejected);
            // Want to create response for this class like above open,approved, rejected filed and complete it 

            //Anothere method
            //var counts = employeeDbContext.LeaveRequest
            //    .Select(l => l.Status.StatusName)
            //    .GroupBy(StatusName => StatusName)
            //    .Select(c => new LeaveRequestStatusCountRequestModel
            //    {
            //        StatusName = c.Key,
            //        Count = c.Count()
            //    })
            //    .ToList();
            //return counts;
            
            var finalLeaveCount = employeeDbContext.LeaveRequest
                .Select(i => new EmployeeDetailsModel
                {
                    LeaveRequestId = i.LeaveRequestId,
                    EmployeeDetailsId = i.EmployeeDetailsId,
                    AdminId = i.AdminId,
                    LeaveReason = i.LeaveReason,
                    FromDate = i.FromDate,
                    ToDate = i.ToDate,
                    TotalLeaves = i.TotalLeaves,
                }).ToList();

            return new LeaveRequestCountResponseModel()
            {
                EmployeeDetailsModel = finalLeaveCount,
                StatusModelCount = new StatusModelCount
                {
                    Open = OpenCount,
                    Approved = ApprovedCount,
                    Rejected = RejectedCount,
                }
            };



    } }
}

