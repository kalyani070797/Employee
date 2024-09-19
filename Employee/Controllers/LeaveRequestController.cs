using Employee.Core.LeaveRequests.Implementation;
using Employee.Core.LeaveRequests.Interface;
using Employee.Model;
using Employee.Model.LeaveRequests;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Employee.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LeaveRequestController(
                                          ILeaveRequestCreator leaveRequestCreator,
                                          ILeaveRequestInformation leaveRequestInformation,
                                          ILeaveRequestInformationById leaveRequestInformationById,
                                          ILeaveRequestUpdator leaveRequestUpdator,
                                          ILeaveRequestStatusCountor leaveRequestStatusCountor,
                                          ILeaveRequestInformationByDate leaveRequestInformationByDate) : ControllerBase
    {
        // GET: api/<LeaveRequestController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<LeaveRequestController>/5
        [HttpGet("GetAllLeaveRequestDetails")]
        public List<LeaveRequestResponseModel> GetAllLeaveRequest()
        {
            return leaveRequestInformation.GetAllLeaveRequest();
        }

        [HttpGet("GetAllLeaveRequestDetailsById")]
        public CommonApi GetLeaveRequest(int leaveRequestId)
        {
            var getData=leaveRequestInformationById.GetAllLeaveRequestById(leaveRequestId);
            return new CommonApi
            {
                Data = getData,
                Message = "Get All the Details "

            };

        }
        [HttpGet("GetInformationByDate")]
        public CommonApi GetLeaveRequestByDate(DateTime fromDate)
        {
            var getData= leaveRequestInformationByDate.GetLeaveRequestByDate(fromDate);
            return new CommonApi
            {
                Data = getData,
                StatusCode = System.Net.HttpStatusCode.OK,
            };
        }
        [HttpGet("StatusCount")]
        public LeaveRequestCountResponseModel StatusCount()
        {
            return leaveRequestStatusCountor.StatusCount();
        }

        // POST api/<LeaveRequestController>
        [HttpPost]
        public void Post([FromBody] LeaveRequestRequestModel leaveRequestRequest)
        {
            leaveRequestCreator.CreateLeaveRequest(leaveRequestRequest);
        }

        // PUT api/<LeaveRequestController>/5
        [HttpPut("{id}")]
        public CommonApi Put(int leaveRequestId, LeaveRequestRequestModel leaveRequestRequestModel)
        {
            return new CommonApi
            {
                
                Message = "Successful Inserted"
                
            };

            leaveRequestUpdator.UpdateLeaveRequest(leaveRequestId, leaveRequestRequestModel);
        }

        // DELETE api/<LeaveRequestController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
