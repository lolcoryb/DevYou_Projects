using System;

namespace madlibsagain
{
    class Program
    {
        static void Main(string[] args)
        {
            {   //header
                Console.WriteLine("~~~~~~~~~~~~~~~\r\nWelcome to Madlib!\r\n~~~~~~~~~~~~~~~");
                
                //player input
                Console.WriteLine("Please enter an adjective : ");
                string Run = Console.ReadLine();

                Console.WriteLine("Please enter a noun: ");
                string Dog = Console.ReadLine();

                Console.WriteLine("Please enter a verb: past tense: ");
                string Left = Console.ReadLine();

                Console.WriteLine("Please enter an adverb: ");
                string Loudly = Console.ReadLine();

                Console.WriteLine("Please enter an adjective: ");
                string Ugly = Console.ReadLine();

                Console.WriteLine("Please enter a noun: ");
                string Hair = Console.ReadLine();

                Console.WriteLine("Please enter a noun: ");
                string Bathtub = Console.ReadLine();
                
                Console.WriteLine("Please enter an adjective: ");
                string Hot = Console.ReadLine();
                
                Console.WriteLine("Please enter a verb: ");
                string Fly = Console.ReadLine();
                
                Console.WriteLine("Please enter an adverb: ");
                string Quietly = Console.ReadLine();

                Console.WriteLine("Please enter a verb: past tense: ");
                string Fired = Console.ReadLine();

                Console.WriteLine("Please enter an adjective: ");
                string Boring = Console.ReadLine();

                //Story Time Baby
                String Story = "Today I went to the zoo. I saw a " + Run + " " + Dog + " jumping up and down in its tree.\r\nHe " + Left + " " + Loudly + " through the large tunnel that led to its " + Ugly + " " + Hair + " .\r\n I got some peanuts and passed them through the cage to a gigantic gray " + Bathtub + " towering above my head.\r\n Feeding that animal made me hungry. I went to get a " + Hot + " scoop of ice cream. It filled my stomach.\r\n Afterwards I had to " + Fly + " " + Quietly + " to catch our bus. When I got home I " + Fired + " my mom for a " + Boring + " day at the zoo.";
                Console.WriteLine(Story);

                Console.WriteLine("Press enter to exit");
                Console.ReadKey();
            }
        }
    }
}

            
        

