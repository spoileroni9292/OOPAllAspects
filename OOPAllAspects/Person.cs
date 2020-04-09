using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAllAspects
{
    class Person : ICrudable
    {
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
        }

        public Person(string name)
        {
            this.name = name;
        }

        public override string ToString()
        {
            return "Person: " + name;
        }

        public void Create()
        {
            Console.WriteLine($"The person with name: {name} has been created");
        }

        public void Read()
        {
            Console.WriteLine($"The person details are : {name}");
        }

        public void Update()
        {
            Console.WriteLine($"The person with name: {name} has been updated");
        }

        public void Delete()
        {
            Console.WriteLine($"The person with name: {name} has been deleted");
        }
    }
}
