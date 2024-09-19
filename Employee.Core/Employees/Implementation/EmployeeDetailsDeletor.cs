using Employee.Core.Employees.Interface;
using Employee.Infrastructure.PracticeDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Core.Employees.Implementation
{
    public class EmployeeDetailsDeletor(EmployeeDbContext employeeDbContext) : IEmployeeDetailsDeletor
    {
        public void DeleteEmployeeDetails(int employeeDetailsId)
        {
            var deleteEmployeeDetails = employeeDbContext.EmployeeDetails
                                      .Where(i => i.EmployeeDetailsId == employeeDetailsId).FirstOrDefault();
            if (deleteEmployeeDetails != null)
            {
                employeeDbContext.EmployeeDetails.Remove(deleteEmployeeDetails);
                employeeDbContext.SaveChanges();
            }
        }
    }
}
