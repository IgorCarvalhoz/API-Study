using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Study.Entities
{
    public class Contact //This class will be the atributes of the table in SQL by the migrations and the table recieve all this atributes
    {
        public string? Name {get; set;}
        public string? Phone { get; set; }
        public bool Active { get; set; }
        public int ID { get; set; }
    }
}