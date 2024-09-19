using Employee.Infrastructure.PracticeDbContext;
using Employee.Infrastructure.Tables;
using Employee.Model.LeaveApprovals;
using Employee.Model.LeaveRequests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Core.LogInValidation.Admins
{
    public class AdminLoginDetails(EmployeeDbContext employeeDbContext) : IAdminLoginDetails
    {
        public bool AdminLogin(string username, string password)
        {
            var adminLogin = employeeDbContext.Admin
                .FirstOrDefault(i => i.Email == username && i.Password == password);
            if (adminLogin != null)
            {
                return true;
            }
            return false;
        }        
    }
}
