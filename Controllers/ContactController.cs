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
        [HttpDelete]
        public IActionResult Delete(Contact contact){ //This method createthe Delete action in schedule Table, here we can remove the infos in DB.
            _context.Remove(contact);
            _context.SaveChanges();
            return Ok(contact);
        }
        [HttpGet("{id}")]
        public IActionResult GetID(int id){
            var contato = _context.Contacts.Find(id);
            if (contato == null){
                return NotFound();
            }
            return Ok(contato);
        }
        
        public IActionResult Update(int id, Contact contact){
            var contactDBA = _context.Contacts.Find(id);
            if (contactDBA == null){
                return NotFound();
            }
            contactDBA.Name = contact.Name;
            return Ok(contact);
        }
    }
}