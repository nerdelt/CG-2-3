using System;

namespace Album_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Have a real or made-up band? Let's find the perfect name for your first album!");
            Console.Write("What is your favorite ice cream flavor? ");
            string myIceCream = Console.ReadLine();

            Console.Write("What is your favorite animal? ");
            string myAnimal = Console.ReadLine();

            Console.Write("What is your favorite season? ");
            string mySeason = Console.ReadLine();

            Console.WriteLine("Your album name is: " + myIceCream + " " + myAnimal + "s " + "in the " + mySeason);
            Console.ReadLine();


        }
    }
}
