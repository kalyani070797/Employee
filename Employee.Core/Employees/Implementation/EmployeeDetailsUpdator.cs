using Employee.Core.Employees.Interface;
using Employee.Infrastructure.PracticeDbContext;
using Employee.Model.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Core.Employees.Implementation
{
    public class EmployeeDetailsUpdator(EmployeeDbContext employeeDbContext) : IEmployeeDetailsUpdator
    {
        public void UpdateEmployeeDetails(int employeeDetailsId, EmployeeDetailsRequestModel employeeDetailsRequest)
        {
            var updateEmployeeDetails = employeeDbContext.EmployeeDetails
                                     .First(i => i.EmployeeDetailsId == employeeDetailsId);

                updateEmployeeDetails.FirstName = employeeDetailsRequest.FirstName;
                updateEmployeeDetails.LastName = employeeDetailsRequest.LastName;
                updateEmployeeDetails.Email = employeeDetailsRequest.Email;
                updateEmployeeDetails.Password = employeeDetailsRequest.Password;
                updateEmployeeDetails.PhoneNumber = employeeDetailsRequest.PhoneNumber;
                updateEmployeeDetails.Address = employeeDetailsRequest.Address;
                updateEmployeeDetails.EmployeeAge = employeeDetailsRequest.EmployeeAge;
                updateEmployeeDetails.Department = employeeDetailsRequest.Department;
            employeeDbContext.SaveChanges();

        }
    }
}
