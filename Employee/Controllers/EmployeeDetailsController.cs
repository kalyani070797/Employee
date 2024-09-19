using Employee.Core.Employees.Interface;
using Employee.Infrastructure.Tables;
using Employee.Model.Employees;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Employee.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeDetailsController(
                                            IEmployeeDetailsCreator employeeDetailsCreation,
                                            IEmployeeDetailsUpdator employeeDetailsUpdator,
                                            IEmployeeDetailsDeletor employeeDetailsDeletion,
                                            IEmployeeDetailsInformation employeeDetailsInformation) : ControllerBase
    {
        // GET: api/<EmployeeDetailsController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<EmployeeDetailsController>/5
        [HttpGet("{id}")]
        public EmployeeDetailsResponseModel Get(int EmployeeDetailsId)
        {
            return employeeDetailsInformation.GetSingleEmployee(EmployeeDetailsId);
            
            
        }
        [HttpGet("List of EmployeeDetails")]
        public List<EmployeeDetailsResponseModel> getEmployeeDetails()
        {
            var get = employeeDetailsInformation.GetAllEmployeeDetails();
            return get;
        }

        // POST api/<EmployeeDetailsController>
        [HttpPost]
        public void Post([FromBody] EmployeeDetailsRequestModel employeeDetailsRequest)
        {
            employeeDetailsCreation.CreateEmployeeDetails(employeeDetailsRequest);
        }

        // PUT api/<EmployeeDetailsController>/5
        [HttpPut("{id}")]
        public void Put(int employeeDetailsid, [FromBody] EmployeeDetailsRequestModel employeeDetailsRequest)
        {
            employeeDetailsUpdator.UpdateEmployeeDetails(employeeDetailsid, employeeDetailsRequest);
        }

        // DELETE api/<EmployeeDetailsController>/5
        [HttpDelete("{id}")]
        public void Delete(int employeeDetailsId)
        {
            employeeDetailsDeletion.DeleteEmployeeDetails(employeeDetailsId);
        }
    }
}
