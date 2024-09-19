using Employee.Core.Employees.Interface;
using Employee.Core.Salaries.Interface;
using Employee.Model;
using Employee.Model.EmployeeSalary;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Employee.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeSalaryController(
                                            IEmployeeSalaryCreator employeeSalaryCreator,
                                            IEmployeeSalaryUpdator employeeSalaryUpdator,
                                            IEmployeeSalaryDeletor employeeSalaryDeletor,
                                            IEmployeeSalaryInformation employeeSalaryInformation,
                                            IEmployeeSalaryDetailsGet employeeSalaryDetailsGet) : ControllerBase
    {
        // GET: api/<EmployeeSalaryController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<EmployeeSalaryController>/5
        [HttpGet("{id}")]
        public EmployeeSalaryResponseModel Get(int employeeSalaryId)
        {
          return  employeeSalaryInformation.GetSingleId(employeeSalaryId);
        }
        [HttpGet("Get All EmployeeSalaryDetails")]
        public List<EmployeeSalaryResponseModel> GetAll()
        {
            return employeeSalaryInformation.GetAllEmployeeSalary();
        }

        // POST api/<EmployeeSalaryController>
        [HttpPost]
        public void Post([FromBody] EmployeeSalaryRequestModel employeeSalaryRequest)
        {
            employeeSalaryCreator.CreateEmployeeSalary(employeeSalaryRequest);
        }

        // PUT api/<EmployeeSalaryController>/5
        [HttpPut("{id}")]
        public void Put(int employeeSalaryId, [FromBody] EmployeeSalaryRequestModel employeeSalaryRequest)
        {
            employeeSalaryUpdator.UpdateEmployeeSalary(employeeSalaryId,employeeSalaryRequest);
        }

        // DELETE api/<EmployeeSalaryController>/5
        [HttpDelete("{id}")]
        public void Delete(int employeeSalaryId)
        {
            employeeSalaryDeletor.DeleteEmployeeSalary(employeeSalaryId);
        }
        [HttpGet("Get All SalaryDetails based on EmployeeDetailsId")]
        public List<SalaryDetailsResponseModel> GetAllEmployeeSalaryDetails(int employeeDetailId)
        {
            return employeeSalaryDetailsGet.GetEmployeeSalaryDetails(employeeDetailId);
        }
    }
}
