using Employee.Core.Salaries.Interface;
using Employee.Infrastructure.PracticeDbContext;
using Employee.Infrastructure.Tables;
using Employee.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Core.Salaries.Implementation
{
    public class EmployeeSalaryCreator(EmployeeDbContext employeeDbContext) : IEmployeeSalaryCreator
    {
        public void CreateEmployeeSalary(EmployeeSalaryRequestModel employeeSalaryRequest)
        {
            var createEmployeeSalary = new EmployeeSalary()
            {
                EmployeeDetailsId = employeeSalaryRequest.EmployeeDetailsId,
                BasicSalary = employeeSalaryRequest.BasicSalary,
                TravelAllowances = employeeSalaryRequest.TravelAllowances,
               SpecialAllowances = employeeSalaryRequest.SpecialAllowances,
                TaxAmont = employeeSalaryRequest.TaxAmont,
                Insurance= employeeSalaryRequest.Insurance,
                BonusAmount= employeeSalaryRequest.BonusAmount,
                NetSalary = employeeSalaryRequest.NetSalary,
            };
            employeeDbContext.EmployeeSalary.Add(createEmployeeSalary);
            employeeDbContext.SaveChanges();
        }


    }
}
