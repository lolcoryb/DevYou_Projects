using System;

namespace vacationbudgetplanner
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string destination;


            Console.WriteLine("~Welcome to the Capstone Project~");

            Console.WriteLine("Please enter your name : ");
            name = Console.ReadLine();

            Console.WriteLine($"Welcome {name}! Which of these two countries would you rather travel to? Mexico or Jamaica?");
            destination = Console.ReadLine();

            Console.WriteLine($"{destination} eh? Sounds fun!");

            Console.WriteLine("Press enter to exit");
            Console.ReadKey();
        }
    }
}
