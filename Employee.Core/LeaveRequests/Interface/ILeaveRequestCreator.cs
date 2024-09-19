using Employee.Model.LeaveRequests;

namespace Employee.Core.LeaveRequests.Interface
{
    public interface ILeaveRequestCreator
    {
        void CreateLeaveRequest(LeaveRequestRequestModel leaveRequestRequest);
    }
}