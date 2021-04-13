using System;

namespace madlibs
{
    class Program
    {
        static void Main(string[] args)
        {//declare variables
            string Run;
            string Dog;
            string Left;
            string Loudly;
            string Ugly;
            string Hair;
            string Bathtub;
            string Hot;
            string Fly;
            string Quietly;
            string Fired;
            string Boring;

            //header and instructions
            Console.WriteLine("~~~~~~~~~~~~~~~");
            Console.WriteLine("Welcome to Madlib!");
            Console.WriteLine("~~~~~~~~~~~~~~~");

            //player input
            Console.WriteLine("Please enter an adjective : ");
            Run = Console.ReadLine();

            Console.WriteLine("Please enter a noun: ");
            Dog = Console.ReadLine();

            Console.WriteLine("Please enter a verb: past tense: ");
            Left = Console.ReadLine();

            Console.WriteLine("Please enter an adverb: ");
            Loudly = Console.ReadLine();

            Console.WriteLine("Please enter an adjective: ");
            Ugly = Console.ReadLine();

            Console.WriteLine("Please enter a noun: ");
            Hair = Console.ReadLine();

            Console.WriteLine("Please enter a noun: ");
            Bathtub = Console.ReadLine();

            Console.WriteLine("Please enter an adjective: ");
            Hot = Console.ReadLine();

            Console.WriteLine("Please enter a verb: ");
            Fly = Console.ReadLine();

            Console.WriteLine("Please enter an adverb: ");
            Quietly = Console.ReadLine();

            Console.WriteLine("Please enter a verb: past tense: ");
            Fired = Console.ReadLine();

            Console.WriteLine("Please enter an adjective: ");
            Boring = Console.ReadLine();

            //Story Time Baby
            String Story = "Today I went to the zoo. I saw a " + Run + " " + Dog + " jumping up and down in its tree.\r\nHe " + Left + " " + Loudly + " through the large tunnel that led to its " + Ugly + " " + Hair + " .\r\n I got some peanuts and passed them through the cage to a gigantic gray " + Bathtub + " towering above my head.\r\n Feeding that animal made me hungry. I went to get a " + Hot + " scoop of ice cream. It filled my stomach.\r\n Afterwards I had to " + Fly + " " + Quietly + " to catch our bus. When I got home I " + Fired + " my mom for a " + Boring + " day at the zoo.";
            Console.WriteLine( Story );

            Console.WriteLine("Press enter to exit");
            Console.ReadKey();









        }

        }
}
