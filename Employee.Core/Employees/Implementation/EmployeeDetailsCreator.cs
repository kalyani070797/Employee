using Employee.Core.Employees.Interface;
using Employee.Infrastructure.PracticeDbContext;
using Employee.Infrastructure.Tables;
using Employee.Model.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Core.Employees.Implementation
{
    public class EmployeeDetailsCreator(EmployeeDbContext employeeDbContext) : IEmployeeDetailsCreator
    {
        public void CreateEmployeeDetails(EmployeeDetailsRequestModel employeeDetailsRequest)
        {
            var employeeDetails = new EmployeeDetails()
            {
                FirstName = employeeDetailsRequest.FirstName,
                LastName = employeeDetailsRequest.LastName,
                Email = employeeDetailsRequest.Email,
                Password = employeeDetailsRequest.Password,
                PhoneNumber = employeeDetailsRequest.PhoneNumber,
                Address = employeeDetailsRequest.Address,
                EmployeeAge = employeeDetailsRequest.EmployeeAge,
                Department = employeeDetailsRequest.Department,
            };
            employeeDbContext.EmployeeDetails.Add(employeeDetails);
            employeeDbContext.SaveChanges();
        }
    }
}
