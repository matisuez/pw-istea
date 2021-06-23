using System.Collections.Generic;
using Persistencia.Models;

namespace Persistencia.Models
{
    public class Role
    {
        public int Id { set;get; }
        public string Detail { set;get; }

        public List<Person> Person { set;get; }
    }
}