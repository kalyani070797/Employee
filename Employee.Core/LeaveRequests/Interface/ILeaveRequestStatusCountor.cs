using Employee.Model.LeaveRequests;

namespace Employee.Core.LeaveRequests.Interface
{
    public interface ILeaveRequestStatusCountor
    {
        LeaveRequestCountResponseModel StatusCount();
    }
}