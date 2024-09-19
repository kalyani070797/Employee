using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Infrastructure.Tables
{
    public class EmployeeSalary
    {
        public int EmployeeSalaryId { get; set; }
        public int EmployeeDetailsId { get; set; }
        public EmployeeDetails EmployeeDetails { get; set; }
        [Precision(18, 2)]
        public decimal BasicSalary { get; set; }
        [Precision(18, 2)]
        public decimal TravelAllowances { get; set; }
        [Precision(18, 2)]
        public decimal SpecialAllowances { get; set; }
        [Precision(18, 2)]
        public decimal TaxAmont { get; set; }
        [Precision(18, 2)]
        public decimal Insurance { get; set; }
        [Precision(18, 2)]
        public decimal BonusAmount { get; set; }
        [Precision(18, 2)]
        public decimal NetSalary { get; set; }

    }
}