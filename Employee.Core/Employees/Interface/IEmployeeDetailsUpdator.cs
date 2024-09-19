using Employee.Model.Employees;

namespace Employee.Core.Employees.Interface
{
    public interface IEmployeeDetailsUpdator
    {
        void UpdateEmployeeDetails(int employeeDetailsId, EmployeeDetailsRequestModel employeeDetailsRequest);
    }
}