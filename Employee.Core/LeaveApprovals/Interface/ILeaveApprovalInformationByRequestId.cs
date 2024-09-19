using Employee.Model.LeaveApprovals;

namespace Employee.Core.LeaveApprovals.Interface
{
    public interface ILeaveApprovalInformationByRequestId
    {
        LeaveApprovalResponseModelByRequestId GetDetailsByRequestId(int leaveRequestId);
    }
}