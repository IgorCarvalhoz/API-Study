using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace API_Study.Controllers
{
        [ApiController]
        [Route("api/[controller]")]
        
        public class UserController : ControllerBase
        {
            [HttpGet("GetDate")]           
            public IActionResult GetDate()
            {
            var obj = new {
                Date = DateTime.Now.ToLongDateString(),
                Time = DateTime.Now.ToShortTimeString()
            };
            return Ok(obj);
        }
        [HttpGet ("ToPresent/{nome}")]
        public IActionResult ToPresent (string nome){
            var message  = $"Hello{nome} you are welcome";
            return Ok(new{message});
        }
        [HttpGet ("ChampionMain/{championName}")] 
        public IActionResult ChampioMain(string championName){
            var message2 = $"{championName} the Heart of the Freljord";
            var message3 = $"{championName} the Hand of Noxus";
            if (championName == "Darius"){
                return Ok(new {message3});
            }
            else if (championName == "Braum"){
                return Ok(new {message2});
            } 
            return Ok();
        }   
    }
}
