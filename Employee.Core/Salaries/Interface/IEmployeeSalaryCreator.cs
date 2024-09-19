using Employee.Model;

namespace Employee.Core.Salaries.Interface
{
    public interface IEmployeeSalaryCreator
    {
        void CreateEmployeeSalary(EmployeeSalaryRequestModel employeeSalaryRequest);
    }
}