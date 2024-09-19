using Employee.Model.LeaveRequests;

namespace Employee.Core.LeaveRequests.Implementation
{
    public interface ILeaveRequestInformationByDate
    {
        List<LeaveRequestResponseModel> GetLeaveRequestByDate(DateTime fromDate);
    }
}