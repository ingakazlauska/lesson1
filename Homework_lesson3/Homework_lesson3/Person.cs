using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_lesson3
{
    public class Person
    {
        public Person(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public string Surname { get; set; }

        public DateTime Date { get; set; }

        public string Hobby { get; set; }

        public bool IsMale { get; set; }

        public string GetGreeting()
        {
            string greeting = "Hello my name is " + Name + "and I am  " + YearsOld;

            return greeting;
        }
    }

}

