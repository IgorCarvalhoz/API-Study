using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_Study.Entities;
using Microsoft.EntityFrameworkCore;

//Creating the data base communication
namespace API_Study.Context
{
    public class ScheduleContext : DbContext //Data Base class of EntityFramework, it wil create the tables
    {
       
        public ScheduleContext(DbContextOptions <ScheduleContext> options) : base(options)
        //This code snippet reacieve the dba connection and send the infos for base (DBCOntext)
        //We don't need to write anything inside the brackets 
        {
            
        }
        public DbSet<Contact> Contacts { get; set; }
        //This code snippet create the representation table in Data Base, the code recieve the "Contact" class was declared into Entities folder
    }
}