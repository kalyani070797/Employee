using Employee.Model.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Model.EmployeeSalary
{
    public class EmployeeSalaryResponseModel
    {
        public int EmployeeSalaryId { get; set; }
        public int EmployeeDetailsId { get; set; }
        public decimal BasicSalary { get; set; }
        public decimal TravelAllowances { get; set; }
        public decimal SpecialAllowances { get; set; }
        public decimal TaxAmont { get; set; }
        public decimal Insurance { get; set; }
        public decimal BonusAmount { get; set; }
        public decimal NetSalary { get; set; }
    }
}
