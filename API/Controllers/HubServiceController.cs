using API.HubServices;
using Microsoft.AspNetCore.Mvc;
namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HubServiceController(HubService hubService) : ControllerBase
    {
        [HttpGet("GetMembers/{groupName}")]
        public IActionResult GetMembers(string groupName) => Ok(hubService.GetMembers(groupName));

        [HttpGet("availableGroups")]
        public IActionResult GetAvailableGroups() => Ok(hubService.GetAvailableGroups());

        [HttpGet("GetUserGroupName/{connectionId}")]
        public IActionResult GetUserGroupName(string connectionId) => Ok(hubService.GetUserGroupName(connectionId));
    }
}
