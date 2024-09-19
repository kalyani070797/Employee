using Employee.Model.LeaveRequests;

namespace Employee.Core.LeaveRequests.Interface
{
    public interface ILeaveRequestInformation
    {
        List<LeaveRequestResponseModel> GetAllLeaveRequest();
    }
}