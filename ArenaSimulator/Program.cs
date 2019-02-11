using System;
using System.Collections.Generic;
using Lexicon.CSharp.InfoGenerator;

namespace ArenaSimulator
{
    class Program
    {
        static InfoGenerator infoGen = new InfoGenerator();
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Arena Simulator!");
            Console.WriteLine("Here you can create a Gladiator and have it fight other random gladiators.");

            List<Character> gladiators = new List<Character>();

            bool keepAlive = true;

            while (keepAlive)
            {
                Console.WriteLine(
                    "--- Arena Simulator --- \n"+
                    "1: Create Gladiator\n"+
                    "2: Remove Gladiator\n"+
                    "3: Show Gladiators\n"+
                    "4: Fight"+
                    "0: Exit Program"
                    );

                int selection = int.Parse(Console.ReadLine());
                switch (selection)
                {
                    case 1:
                        gladiators.Add(CreateCharacter());
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 0:
                        keepAlive = false;
                        Console.WriteLine("Exiting, Good Bye!");
                        break;
                    default:
                        Console.WriteLine("Not a valid selection!");
                        break;
                }
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey(true);
                Console.Clear();
            }

            Character CreateCharacter()
            {
                Console.WriteLine("Enter a name for your gladiator: ");
                string name = (Console.ReadLine());
                Console.WriteLine("Assign a health value");
                int health = int.Parse(Console.ReadLine());
                int power = 0;
                return new Character(name, health, power);
            }
        }
    }
}
