using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAllAspects
{
    class Product : ICrudable
    {
        public string Name { get; set; }

        public string Code { get; set; }

        public string Description { get; set; }

        public void Create()
        {
            Console.WriteLine($"The product with name: {Name} has been created");
        }

        public void Read()
        {
            Console.WriteLine($"The product details are : {Name}");
        }

        public void Update()
        {
            Console.WriteLine($"The product with name: {Name} has been updated");
        }

        public void Delete()
        {
            Console.WriteLine($"The product with name: {Name} has been deleted");
        }


        public override string ToString()
        {
            return "Product: " + Name + " Code: " + Code + " Description: " + Description;
        }

    }
}
