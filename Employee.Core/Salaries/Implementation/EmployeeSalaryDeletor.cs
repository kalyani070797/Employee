using Employee.Core.Salaries.Interface;
using Employee.Infrastructure.PracticeDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Core.Salaries.Implementation
{
    public class EmployeeSalaryDeletor(EmployeeDbContext employeeDbContext) : IEmployeeSalaryDeletor
    {
        public void DeleteEmployeeSalary(int employeeSalaryId)
        {
            var deleteEmployee = employeeDbContext.EmployeeSalary
                .First(i => i.EmployeeSalaryId == employeeSalaryId);
           
                employeeDbContext.EmployeeSalary.Remove(deleteEmployee);
                employeeDbContext.SaveChanges();            
        }
    }
}
