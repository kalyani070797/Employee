using Employee.Core.Admins.Interface;
using Employee.Infrastructure.PracticeDbContext;
using Employee.Infrastructure.Tables;
using Employee.Model.Admins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Core.Admins.Implementation
{
    public class AdminCreator(EmployeeDbContext employeeDbContext) : IAdminCreator
    {
        
        public void CreateAdmin(AdminRequestModel adminRequest)
        {
            var createAdmin = new Admin()
            {
                FirstName = adminRequest.FirstName,
                LastName = adminRequest.LastName,
                Email = adminRequest.Email,
                Password = adminRequest.Password,
            };
            employeeDbContext.Admin.Add(createAdmin);
            employeeDbContext.SaveChanges();
        }
    }
}
