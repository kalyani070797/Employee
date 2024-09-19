using Employee.Core.Salaries.Interface;
using Employee.Infrastructure.PracticeDbContext;
using Employee.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Core.Salaries.Implementation
{
    public class EmployeeSalaryUpdator(EmployeeDbContext employeeDbContext) : IEmployeeSalaryUpdator
    {
        public void UpdateEmployeeSalary(int employeeSalaryId, EmployeeSalaryRequestModel employeeSalaryRequest)
        {
            var updateEmployeeSalary = employeeDbContext.EmployeeSalary
                                     .First(i => i.EmployeeSalaryId == employeeSalaryId);
            updateEmployeeSalary.EmployeeDetailsId = employeeSalaryRequest.EmployeeDetailsId;
            updateEmployeeSalary.BasicSalary = employeeSalaryRequest.BasicSalary;
            updateEmployeeSalary.TravelAllowances = employeeSalaryRequest.TravelAllowances;
            updateEmployeeSalary.SpecialAllowances = employeeSalaryRequest.SpecialAllowances;
            updateEmployeeSalary.Insurance= employeeSalaryRequest.Insurance;
            updateEmployeeSalary.BonusAmount= employeeSalaryRequest.BonusAmount;
            updateEmployeeSalary.TaxAmont = employeeSalaryRequest.TaxAmont;
            updateEmployeeSalary.NetSalary = employeeSalaryRequest.NetSalary;
           employeeDbContext.SaveChanges();
        }
    }
}
