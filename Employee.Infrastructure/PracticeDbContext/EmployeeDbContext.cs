using Employee.Infrastructure.Tables;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Infrastructure.PracticeDbContext
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options) : base(options)
        {
        }
        public DbSet<EmployeeDetails> EmployeeDetails {  get; set; }
        public DbSet<EmployeeSalary> EmployeeSalary { get; set; }
        public DbSet<Admin> Admin {  get; set; }
        public DbSet<LeaveApproval> LeaveApproval { get; set; }
        public DbSet<LeaveRequest> LeaveRequest {  get; set; }
        public DbSet<Status> Status { get; set; }
        
    }
}
