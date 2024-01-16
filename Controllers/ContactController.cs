using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_Study.Context;
using API_Study.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API_Study.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ContactController : ControllerBase
    {
        public readonly ScheduleContext _context; //Essa propriedade define que a variável _context gravará os dados na tabela ScheduleContext 
        public ContactController(ScheduleContext context)
        {
            _context = context;
        }
        [HttpPost] //Post type
        public IActionResult Create(Contact contact){ //This method create the Create action in Schedule Table, here we can insert infos in DB.
            _context.Add(contact); 
            _context.SaveChanges();
            return Ok(contact);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(Contact contact){ //This method createthe Delete action in schedule Table, here we can remove the infos in DB.
            _context.Remove(contact);
            _context.SaveChanges();
            return NoContent();
        }
        [HttpGet("{id}")]
        public IActionResult GetID(int id){
            var contato = _context.Contacts.Find(id);
            if (contato == null){
                return NotFound();
            }
            return Ok(contato);
        }
        [HttpGet("GetByName")]
        public IActionResult GetByName(string name){
            var contacts = _context.Contacts.Where(x =>  x.Name.Contains(name));
            return Ok(contacts);
        }




        [HttpPut ("{id}")]
        public IActionResult Update(int id, Contact contact){
            var contactDBA = _context.Contacts.Find(id); //Get DBA infos
            if (contactDBA == null){ //Makes the verification if the id found
                return NotFound();
            }
            contactDBA.Name = contact.Name; //Makes the modifications in the DBA receiving the resiquitation parameters "Contact contact"
            contactDBA.Phone = contact.Phone;
            contactDBA.Active = contact.Active;

            _context.Contacts.Update(contactDBA);//Makes the update
            _context.SaveChanges();//Saves the changes
            return Ok(contactDBA);//Get the actualized contact
        } 
    }
}
