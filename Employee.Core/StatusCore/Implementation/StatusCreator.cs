using Employee.Core.StatusCore.Interface;
using Employee.Infrastructure.PracticeDbContext;
using Employee.Infrastructure.Tables;
using Employee.Model.StatusModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Core.StatusCore.Implementation
{
    public class StatusCreator(EmployeeDbContext employeeDbContext) : IStatusCreator
    {
        public void CreateStatus(StatusRequestModel statusRequest)
        {
            var createStatus = new Status()
            {
                StatusName = statusRequest.StatusName,
            };
            employeeDbContext.Status.Add(createStatus);
            employeeDbContext.SaveChanges();
        }
    }
}
