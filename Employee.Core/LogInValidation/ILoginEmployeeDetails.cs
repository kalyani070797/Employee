using Employee.Model.LogIn;

namespace Employee.Core.LogInValidation
{
    public interface ILoginEmployeeDetails
    {
        bool Login(string email,string password);
    }
}