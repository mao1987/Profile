using System;

namespace Profile
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string Name1 = "Jane";
            byte MyAge = 27;
            bool HaveIApet = true;
            double MyShoeSize = 37.5;

            Console.WriteLine("My name is " + Name1);
            Console.WriteLine("MyAge " + MyAge);
            Console.WriteLine("Do I have a pet? " + HaveIApet);
            Console.WriteLine("My shoe size is " + MyShoeSize);

            Console.WriteLine("\t Привет,\n мир!");

            string MyName = "Евгения";
            byte age1 = 34;
            Console.WriteLine($"Меня зовут {MyName}");
                        Console.WriteLine($"Мой возраст {age1}");

            var name = "Anton";
            var age = 34;
            var favcolor = "blue";
            Console.WriteLine("{0}\n {1}\n {2}", name, age, favcolor);
            */

            Console.Write("Введите имя: ");
            var name = Console.ReadLine();
            Console.Write("Введите возраст: ");
            var age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your name is {0} and age is {1}", name, age);
            Console.Write("Введите дату рождения: ");
            var birthdate = Console.ReadLine();
            Console.WriteLine("Your birthdate is {0} ", birthdate);
            Console.ReadKey();
        }
    }
}
