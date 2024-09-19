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
    public class EmployeeDetailsInformation(EmployeeDbContext employeeDbContext) : IEmployeeDetailsInformation
    {
        public EmployeeDetailsResponseModel GetSingleEmployee(int employeeDetailsId)
        {
            var employeeDetailsInfo = employeeDbContext.EmployeeDetails
                                   .Where(i => i.EmployeeDetailsId == employeeDetailsId)
                                   .Select(i => new EmployeeDetailsResponseModel
                                   {
                                       EmployeeDetailsId = i.EmployeeDetailsId,
                                       FirstName = i.FirstName,
                                       LastName = i.LastName,
                                       Email = i.Email,
                                       Password = i.Password,
                                       PhoneNumber = i.PhoneNumber,
                                       EmployeeAge = i.EmployeeAge,
                                       Department = i.Department,
                                   }).FirstOrDefault();
            return employeeDetailsInfo;
        }
        public List<EmployeeDetailsResponseModel> GetAllEmployeeDetails()
        {
            var employeeDetailsInfo = employeeDbContext.EmployeeDetails
                                   .Select(i => new EmployeeDetailsResponseModel
                                   {
                                       EmployeeDetailsId = i.EmployeeDetailsId,
                                       FirstName = i.FirstName,
                                       LastName = i.LastName,
                                       Email = i.Email,
                                       Password = i.Password,
                                       PhoneNumber = i.PhoneNumber,
                                       EmployeeAge = i.EmployeeAge,
                                       Department = i.Department,
                                   }).ToList();
            return employeeDetailsInfo;
        }

    }
}
