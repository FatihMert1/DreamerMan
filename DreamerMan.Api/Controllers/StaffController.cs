using Microsoft.AspNetCore.Mvc;

namespace DreamerMan.Api.Controllers
{
    [ApiController]
    [Route("stuff")]
    public class StaffController: ControllerBase
    {
        [HttpGet]
        public string GetStuff(){
            return "I am table";
        }

        [HttpGet("new")]
        public string GetNew(){
            return "I am new stuff";
        }
        
    }
}