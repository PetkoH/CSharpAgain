using System;



    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please write down your age");
            int MyBirthday = int.Parse(Console.ReadLine());
            Console.WriteLine("I am" + MyBirthday + "years old" );
            Console.WriteLine("In 10 years i will be" + (MyBirthday + 10) + "years old");

        }
    }

