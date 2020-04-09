using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAllAspects
{
    class Student : Person
    {
        public Student(string name) : base(name)
        {

        }

        public override string ToString()
        {
            return "Student: " + Name;
        }


        public override void Create()
        {
            Console.WriteLine($"The student with name: {Name} has been created");
        }

        public override void Read()
        {
            Console.WriteLine($"The student details are : {Name}");
        }

        public override void Update()
        {
            Console.WriteLine($"The student with name: {Name} has been updated");
        }

        public override void Delete()
        {
            Console.WriteLine($"The student with name: {Name} has been deleted");
        }
    }
}
