using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombatSim
{
    public class Creature
    {
        public string Name;
        public int Ath;
        public int Str;
        public int Agi;
        public int Tou;
        public int AC;
        public int Dmg;
        public int Melee;
        public int Per;
        public int Init;
    }

    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Please input the following information for creature 1.");
            Creature Creature1 = GetCreatureInfo(); // Capture first creature's info from user

            Console.WriteLine("Please input the following inforation for creature 2.");
            Creature Creature2 = GetCreatureInfo(); // Capture first creature's info from user

            // RollForInitiative(Creature1, Creature2);

        }

        public static Creature GetCreatureInfo()
        {
            Creature foo = new Creature(); // This block captures the creature's name from user input. 
            int TempNumber = 0;
            Console.WriteLine("Creature's name:");
            foo.Name = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Creature's athleticism"); // This block captures one of the creature's stats from the user with some error checking. All blocks below, unil you reach more comments, do the same thing but for a different attribute.
            while (!int.TryParse(Console.ReadLine(), out TempNumber))
            {
                Console.WriteLine("Please Enter a valid number.");
            }
            foo.Ath = TempNumber;

            Console.WriteLine("Creature's strength");
            while (!int.TryParse(Console.ReadLine(), out TempNumber))
            {
                Console.WriteLine("Please Enter a valid number.");
            }
            foo.Str = TempNumber;

            Console.WriteLine("Creature's agility");
            while (!int.TryParse(Console.ReadLine(), out TempNumber))
            {
                Console.WriteLine("Please Enter a valid number.");
            }
            foo.Agi = TempNumber;

            Console.WriteLine("Creature's toughness");
            while (!int.TryParse(Console.ReadLine(), out TempNumber))
            {
                Console.WriteLine("Please Enter a valid number.");
            }
            foo.Tou = TempNumber;

            Console.WriteLine("Creature's armor");
            while (!int.TryParse(Console.ReadLine(), out TempNumber))
            {
                Console.WriteLine("Please Enter a valid number.");
            }
            foo.AC = TempNumber;

            Console.WriteLine("Creature's melee skill");
            while (!int.TryParse(Console.ReadLine(), out TempNumber))
            {
                Console.WriteLine("Please Enter a valid number.");
            }
            foo.Melee = TempNumber;

            Console.WriteLine("Creature's damage");
            while (!int.TryParse(Console.ReadLine(), out TempNumber))
            {
                Console.WriteLine("Please Enter a valid number.");
            }
            foo.Dmg = TempNumber;

            Console.WriteLine("Creature's perception");
            while (!int.TryParse(Console.ReadLine(), out TempNumber))
            {
                Console.WriteLine("Please Enter a valid number.");
            }
            foo.Per = TempNumber;

            foo.Init = Math.Min(foo.Per, foo.Agi); // Now that all the other values are entered, this calculates the creature's initative. 

            return foo;
        }

        /*
        public static Creature RollForInitiative(Creature C1, Creature C2) // Title says it all.
        {
            Random random = new Random(); // Needed for generating the random numbers.
            int d20a = random.Next(1, 20); // Roll the first d20! In case you aren't enough of a nerd, a "d20" is slang for a 20 sided die. 
            int d20b = random.Next(1, 20); // Roll another d20, just easier to have a couple of them. 
            
            while (C1.Init - d20a == C2.Init - d20b) // This while loop breaks ties in inatitive.
            {
                d20a = random.Next(1, 20);
                d20b = random.Next(1, 20);
            }

            if (C1.Init - d20a > C2.Init - d20b)
            {
                Creature winner = FightToTheDeathForMyAmusement();
            }
        }
        */
    }
}
