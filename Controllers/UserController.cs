using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace API_Study.Controllers
{

    //Creating a controller, the controllers have the organization job. For example everything about the users wil contains in this controller
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        //Giving a function for the controller, in this case a method to obtain date

        [HttpGet("GetDateNow")]
        public IActionResult TodayDate(){

            //Variable who gets the date and the time
            var obj = new {
                Date = DateTime.Now.ToLongDateString(),
                Time = DateTime.Now.ToShortTimeString() 
            };
            return Ok(obj);
        }

    }
}