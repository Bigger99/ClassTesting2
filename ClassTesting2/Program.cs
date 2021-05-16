using System;

namespace ClassTesting2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person Nick = new Person();
            Nick.fullName = "Nick Borrow";
            Nick.age = 20;

            Person Bob = new Person("Bob Anderson", 34);

            Nick.Move("вправо");
            Nick.Talk("Привет");

            Bob.Move("влево");
            Bob.Talk("Пока");

            Console.ReadKey();
        }
    }
}
