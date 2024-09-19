namespace Employee.Core.LeaveApprovals.Interface
{
    public interface ILeaveApprovalCreator
    {
        string CreateLeaveApproval(int leaveRequestId, int statusId);
    }
}