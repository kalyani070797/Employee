﻿using Employee.Model.EmployeeSalary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Model.Employees
{
    public class EmployeeDetailsResponseModel
    {
        public int EmployeeDetailsId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public int EmployeeAge { get; set; }
        public string Department { get; set; }
        public SalaryDetailsResponseModel SalaryDetailsResponseModel { get; set; }
    }
}
