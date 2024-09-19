using Employee.Model.EmployeeSalary;

namespace Employee.Core.Salaries.Interface
{
    public interface IEmployeeSalaryDetailsGet
    {
        List<SalaryDetailsResponseModel> GetEmployeeSalaryDetails(int employeeDetailsId);
    }
}