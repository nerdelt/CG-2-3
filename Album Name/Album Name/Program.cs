using System;

namespace Album_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Have a real or made-up band? Let's find the perfect name for your first album!");
            Console.Write("What is your favorite ice cream flavor? ");
            string icecream = Console.ReadLine();

            Console.Write("What is your favorite animal? ");
            string animal = Console.ReadLine();

            Console.Write("What is your favorite season? ");
            string season = Console.ReadLine();

            Console.WriteLine("Your album name is: " + icecream + " " + animal + "s " + "in the " + season);
            Console.ReadLine();


        }
    }
}
