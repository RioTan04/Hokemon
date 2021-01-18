using System;

namespace Hokemon
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Welcome to HokeWorld - Home of all Hokemon!");

            // INSTANTIATION of new Hokemon.

            Hokemon hoke01 = new Hokemon(); // INSTANTIATE new Hokemon object referred to as hoke01.name.
            hoke01.get_stats();
            Console.WriteLine("Attack Value is : {0}", hoke01.attack_calculator());
            Console.WriteLine("Defense Value is : {0}", hoke01.defense_calculator());

            Console.WriteLine("\n");

            Hokemon hoke02 = new Hokemon();
            hoke02.get_stats();
            Console.WriteLine("Attack Value is : {0}", hoke02.attack_calculator());
            Console.WriteLine("Defense Value is : {0}", hoke02.defense_calculator());

            Console.WriteLine("\n");

            // Team Hinstinct.
            Hinstinct hoke03 = new Hinstinct(); // INSTANTIATE from Hokemon Parent Class.

            // Team Halor.
            Halor hoke04 = new Halor(); //INSTANTIATE from Halor Child Class.

            // Demonstrating an example of POLYMORPHISM.
            hoke03.definition();
            hoke04.definition();


            /*
            Battle_Arena newBattleObject = new Battle_Arena();

            newBattleObject.request_challenge(hoke02);

            newBattleObject.the_battle(hoke02, hoke01);
            */
        }
    }
}
