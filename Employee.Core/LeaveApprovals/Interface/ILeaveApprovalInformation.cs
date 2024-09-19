using Employee.Model.LeaveApprovals;

namespace Employee.Core.LeaveApprovals.Interface
{
    public interface ILeaveApprovalInformation
    {
        List<LeaveApprovalResponseModel> GellAllLeaveApproval();
    }
}