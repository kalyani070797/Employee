using Employee.Model.Employees;

namespace Employee.Core.Employees.Interface
{
    public interface IEmployeeDetailsInformation
    {
        List<EmployeeDetailsResponseModel> GetAllEmployeeDetails();
        EmployeeDetailsResponseModel GetSingleEmployee(int employeeDetailsId);
    }
}