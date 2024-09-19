using Employee.Model;

namespace Employee.Core.Salaries.Interface
{
    public interface IEmployeeSalaryUpdator
    {
        void UpdateEmployeeSalary(int employeeSalaryId, EmployeeSalaryRequestModel employeeSalaryRequest);
    }
}