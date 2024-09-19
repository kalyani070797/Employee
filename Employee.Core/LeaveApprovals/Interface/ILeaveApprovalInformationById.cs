using Employee.Model.LeaveApprovals;

namespace Employee.Core.LeaveApprovals.Interface
{
    public interface ILeaveApprovalInformationById
    {
        LeaveApprovalResponseModel GellAllLeaveApprovalById(int leaveApprovalId);
    }
}