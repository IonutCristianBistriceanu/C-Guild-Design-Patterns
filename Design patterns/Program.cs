using System;
using Design_patterns.Prototype;

namespace Design_patterns
{
    class Program
    {
      


        static void Main(string[] args)
        {
            var john = new Person("John", new Address("Victoriei", 123));

            var jane = john.DeepCopy();
            jane.Name = "Jane";

            Console.WriteLine(john);
            Console.WriteLine(jane);
        }
    }
}