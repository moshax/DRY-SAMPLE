using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRY4
{
    public class Person
    {
        public string State => Constants.STATE;
        public string City => Constants.CITY;
        public int Age { get; set; }
        public string Name { get; set; }
        
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void PrintInformation()
        {
            Console.WriteLine($"{Name} lives in {City}, " +
              $"{State} and he is {Age} years old!");
        }
    }
}
