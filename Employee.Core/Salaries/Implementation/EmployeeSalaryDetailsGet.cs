using Employee.Core.Salaries.Interface;
using Employee.Infrastructure.PracticeDbContext;
using Employee.Model.EmployeeSalary;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Core.Salaries.Implementation
{
    public class EmployeeSalaryDetailsGet(EmployeeDbContext employeeDbContext) : IEmployeeSalaryDetailsGet
    {
        public List<SalaryDetailsResponseModel> GetEmployeeSalaryDetails(int employeeDetailsId)
        {
            var getEmployeeSalaryDetails = employeeDbContext.EmployeeSalary
              
                .Where(i => i.EmployeeDetailsId == employeeDetailsId)
                .Select(i => new SalaryDetailsResponseModel
                {
                  
                 
                    EmployeeSalaryId = i.EmployeeSalaryId,
                    EmployeeDetailsId = i.EmployeeDetailsId,
                    BasicSalary = i.BasicSalary,
                    NetSalary = i.NetSalary,
                    //Allowance Details
                    Allowances = new Allowances
                    {
                        BonusAmount = i.BonusAmount,
                        TravelAllowances = i.TravelAllowances,
                        SpecialAllowances = i.SpecialAllowances,
                    },
                    //Deduction details
                    Deductions = new Deductions
                    {
                        Insurance = i.Insurance,
                        TaxAmont = i.TaxAmont,
                    }
                }).ToList();
            return getEmployeeSalaryDetails;

        }





    }
}

