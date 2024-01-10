using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Study.Entities
{
    public class Contact
    {
        public Contact(string name, string phone, bool active, int id)
        {
            Name = name;
            Phone = phone;
            Active = active;
            ID = id;
        }
        public string Name { get; set; }
        public string Phone { get; set; }
        public bool Active { get; set; }
        public int ID { get; set; }
    }
}