using System;
using System.Collections.Generic;
using System.Text;

namespace ClassTesting2
{
    class Person
    {

        public string fullName;
        public int age;

        public void Move(string move) {
            Console.WriteLine($"Персонаж {this.fullName} двигается {move}");
        }

        public void Talk(string talk)
        {
            Console.WriteLine($"Персонаж {this.fullName} сказал {talk}");
        }

        public Person() {
            fullName = "";
            age = 0;
        }

        public Person(string fullName, int age)
        {
            this.fullName = fullName;
            this.age = age;
        }
    }
}
