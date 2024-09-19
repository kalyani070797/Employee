using Employee.Core.Employees.Implementation;
using Employee.Infrastructure.PracticeDbContext;
using Employee.Model.LogIn;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Core.LogInValidation
{
    public class LoginEmployeeDetails(EmployeeDbContext employeeDbContext) : ILoginEmployeeDetails
    {
        public bool Login(string email,string password )
        {
            var logIn = employeeDbContext.EmployeeDetails
                     .FirstOrDefault(i => i.Email == email && i.Password == password );
            if (logIn != null)
            {
               
                return true;
            }
            return false;
        }
    }
}
