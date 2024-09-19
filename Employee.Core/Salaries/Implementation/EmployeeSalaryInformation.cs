using Employee.Core.Salaries.Interface;
using Employee.Infrastructure.PracticeDbContext;
using Employee.Model.EmployeeSalary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Core.Salaries.Implementation
{
    public class EmployeeSalaryInformation(EmployeeDbContext employeeDbContext) : IEmployeeSalaryInformation
    {
        public EmployeeSalaryResponseModel GetSingleId(int employeeSalaryId)
        {
            var getInfo = employeeDbContext.EmployeeSalary
                     .Where(i => i.EmployeeSalaryId == employeeSalaryId)
                    .Select(i => new EmployeeSalaryResponseModel
                    {
                        EmployeeSalaryId = i.EmployeeSalaryId,
                        EmployeeDetailsId = i.EmployeeDetailsId,
                        BasicSalary = i.BasicSalary,
                        TravelAllowances = i.TravelAllowances,
                        SpecialAllowances = i.SpecialAllowances,
                        Insurance=i.Insurance,
                        BonusAmount=i.BonusAmount,
                        TaxAmont = i.TaxAmont,
                        NetSalary = i.NetSalary,
                    }).FirstOrDefault();
            return getInfo;
        }
        public List<EmployeeSalaryResponseModel> GetAllEmployeeSalary()
        {
            var GetAllInfo = employeeDbContext.EmployeeSalary
                 .Select(i => new EmployeeSalaryResponseModel
                 {
                     EmployeeSalaryId = i.EmployeeSalaryId,
                     EmployeeDetailsId = i.EmployeeDetailsId,
                     BasicSalary = i.BasicSalary,
                     TravelAllowances = i.TravelAllowances,
                     SpecialAllowances = i.SpecialAllowances,
                     Insurance = i.Insurance,
                     BonusAmount = i.BonusAmount,
                     TaxAmont = i.TaxAmont,
                     NetSalary = i.NetSalary,


                 }).ToList();
            return GetAllInfo;
        }
    }
}
