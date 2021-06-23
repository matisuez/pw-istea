using System.Collections.Generic;
using Persistencia.Models;

namespace Persistencia.Models
{
    public class Person
    {
        public int Id { get;set; }
        public string Name { get;set; }
        public string Surname { get;set; }
        public string Email { get;set; }
        public bool Available { get;set; }
        //public Role Role { set;get; }
    }
}
