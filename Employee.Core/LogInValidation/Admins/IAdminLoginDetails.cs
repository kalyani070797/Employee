using Employee.Model.LeaveRequests;

namespace Employee.Core.LogInValidation.Admins
{
    public interface IAdminLoginDetails
    {
        bool AdminLogin(string username, string password);
    }
}