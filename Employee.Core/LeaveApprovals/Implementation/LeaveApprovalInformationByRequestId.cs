using Employee.Core.LeaveApprovals.Interface;
using Employee.Infrastructure.PracticeDbContext;
using Employee.Model.LeaveApprovals;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Core.LeaveApprovals.Implementation
{
    public class LeaveApprovalInformationByRequestId(EmployeeDbContext employeeDbContext) : ILeaveApprovalInformationByRequestId
    {
        public LeaveApprovalResponseModelByRequestId GetDetailsByRequestId(int leaveRequestId)
        {
            var getDetailsByRequestId = employeeDbContext.LeaveApproval
                .Include(i => i.LeaveRequest)
                                      .Where(i => i.LeaveRequestId == leaveRequestId)
                                      .Select(i => new LeaveApprovalResponseModelByRequestId
                                      {
                                          LeaveApprovalId = i.LeaveApprovalId,
                                          LeaveRequestId = i.LeaveRequestId,
                                          LeaveApprovedDate = i.LeaveApprovedDate,
                                          LeaveRequestModel = new LeaveRequestModel
                                          {
                                              EmployeeDetailsId = i.LeaveRequest.EmployeeDetailsId,
                                              AdminId = i.LeaveRequest.AdminId,
                                              LeaveReason = i.LeaveRequest.LeaveReason,
                                              StatusId = i.LeaveRequest.StatusId,
                                              LeaveType = i.LeaveRequest.LeaveType,
                                              FromDate = i.LeaveRequest.FromDate,
                                              ToDate = i.LeaveRequest.ToDate,
                                              TotalLeaves = i.LeaveRequest.TotalLeaves,
                                          }
                                      }).FirstOrDefault();
            return getDetailsByRequestId;
        }
    }
}
