using Employee.Model.LeaveRequests;

namespace Employee.Core.LeaveRequests.Interface
{
    public interface ILeaveRequestInformationById
    {
        LeaveRequestResponseModel GetAllLeaveRequestById(int leaveRequestId);
    }
}