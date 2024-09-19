using Employee.Model.Employees;

namespace Employee.Core.Employees.Interface
{
    public interface IEmployeeDetailsCreator
    {
        void CreateEmployeeDetails(EmployeeDetailsRequestModel employeeDetailsRequest);
    }
}