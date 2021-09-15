using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3_3
{
    public class Phone
    {

        public string Type { get; set; }
        public string Model { get; set; }
        public int Length { get; set; }   
        public int  Hihg { get; set; }
        public int Width { get; set; }

        public bool MethodCall { get; set; }
        public bool MethodSendSMS { get; set; }

        public String GetType()
                string type = "My phone type is " + Type + " and I am " + Age + " years old!";
    }
}


    public class Person

    {

        public Person(string name)
        {
            Name = name;
        }
        public string Name { get; }

        private int _age;
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                _age = Math.Abs(value);
            }
        }

        public int Age2 { get; set; }

        public double Money { get; set; }

        public bool IsMale { get; set; }

        public char Initial { get; set; }

        public String GetGreeting()
        {
            string greeting = "Hello, my name is " + Name + " and I am " + Age + " years old!";

            return greeting;


        }
    }
}
