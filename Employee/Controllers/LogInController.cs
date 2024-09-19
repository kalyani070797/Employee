using Employee.Core.LogInValidation;
using Employee.Core.LogInValidation.Admins;
using Employee.Model.LogIn;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Employee.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LogInController(
                                  ILoginEmployeeDetails loginEmployeeDetails,
                                  IAdminLoginDetails adminLoginDetails) : ControllerBase
    {
        // GET: api/<LogInController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<LogInController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<LogInController>
        [HttpGet("LoginValidation")]
        public string Login(string email,string password)
        {
            var log= loginEmployeeDetails.Login(email,password);
            if(log==true)
            {
                return "Login Successful";
            }
            return "Failed login";

        }

        [HttpGet("AdminLoginValidation")]
        public string AdminLogin(string email, string password)
        {
            var login=adminLoginDetails.AdminLogin(email,password);
            if (login == true)
            {
                return "Admin Login Successful";
            }
            return "Admin Failed login";
        }

        // PUT api/<LogInController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<LogInController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
        
    }
}
