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
    public class LeaveRequestUpdator(EmployeeDbContext employeeDbContext) : ILeaveRequestUpdator
    {
        public void UpdateLeaveRequest(int leaveRequestId, LeaveRequestRequestModel leaveRequestRequest)
        {
            var checkLeaveRequest = employeeDbContext.LeaveRequest
                .First(i => i.LeaveRequestId == leaveRequestId);
            if (checkLeaveRequest.StatusId == (int)EnumStatusName.Open)
            {

                checkLeaveRequest.AdminId = leaveRequestRequest.AdminId;
                checkLeaveRequest.LeaveReason = leaveRequestRequest.LeaveReason;
                checkLeaveRequest.LeaveType = leaveRequestRequest.LeaveType;
                checkLeaveRequest.FromDate = leaveRequestRequest.FromDate;
                checkLeaveRequest.ToDate = leaveRequestRequest.ToDate;
                checkLeaveRequest.TotalLeaves = (leaveRequestRequest.ToDate - leaveRequestRequest.FromDate).Days + 1;                  
                
                employeeDbContext.SaveChanges();
            }
      
        }
    }
}
