using Employee.Model.LeaveRequests;

namespace Employee.Core.LeaveRequests.Interface
{
    public interface ILeaveRequestUpdator
    {
        void UpdateLeaveRequest(int leaveRequestId, LeaveRequestRequestModel leaveRequestRequest);
    }
}