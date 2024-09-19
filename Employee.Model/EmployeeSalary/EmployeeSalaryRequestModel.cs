using Employee.Model.EmployeeSalary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Model
{
    public class EmployeeSalaryRequestModel
    {
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
