using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    public class Person
    {
        public Person(int id, string lastName, string name)
        {
            this.Id = id;
            this.LastName = lastName;
            this.Name = name;
        }

        public int Id { get; set; }
        public string LastName { get; set; }
        public string Name { get; set; }

        
    }
    
}
