using Employee.Core.LeaveApprovals.Implementation;
using Employee.Core.LeaveApprovals.Interface;
using Employee.Model.LeaveApprovals;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Employee.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LeaveApprovalController( 
                                          ILeaveApprovalCreator leaveApprovalCreator,
                                          ILeaveApprovalInformation leaveApprovalInformation,
                                          ILeaveApprovalInformationById leaveApprovalInformationById,
                                          ILeaveApprovalInformationByRequestId leaveApprovalInformationByRequestId) : ControllerBase
    {
        // GET: api/<LeaveApprovalController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<LeaveApprovalController>/5
        [HttpGet("GetAllLeaveApproval")]
        public List<LeaveApprovalResponseModel> GetAllLeaveApprovals()
        {
           return leaveApprovalInformation.GellAllLeaveApproval();
        }

        [HttpGet("GetAllLeaveApprovalById")]
        public LeaveApprovalResponseModel Get(int leaveApprovalId)
        {
            return leaveApprovalInformationById.GellAllLeaveApprovalById(leaveApprovalId);
        }
        [HttpGet("GetAllLeaveApprovalByLeaveRequestId")]
        public LeaveApprovalResponseModelByRequestId GetAllByRequestId(int leaveRequestId)
        {
            return leaveApprovalInformationByRequestId.GetDetailsByRequestId(leaveRequestId);
        }

        // POST api/<LeaveApprovalController>
        [HttpPost("LeaveApproval")]
        public string Post( int leaveRequestId, int statusId)
        {
           return leaveApprovalCreator.CreateLeaveApproval( leaveRequestId, statusId);
        }

        // PUT api/<LeaveApprovalController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<LeaveApprovalController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
