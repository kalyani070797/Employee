using Employee.Model.EmployeeSalary;

namespace Employee.Core.Salaries.Interface
{
    public interface IEmployeeSalaryInformation
    {
        List<EmployeeSalaryResponseModel> GetAllEmployeeSalary();
        EmployeeSalaryResponseModel GetSingleId(int employeeSalaryId);
    }
}