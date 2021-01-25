using System;

namespace Hokemon
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaring variables to use in the game.

            Hokemon[] challengers = new Hokemon[3];

            for (int i = 0; i < 3; i++)
            {
                challengers[i] = new Hokemon(); // INSTANTIATING each new Hokemon Challenger
            }



            Battle_Arena newBattleObject = new Battle_Arena();

            Random rnd = new Random();

            Boolean repeat_game = true; // To ask user if they want another battle.
            string result;

            Console.WriteLine("Hello, Welcome to HokeWorld - Home of all Hokemon!");

            Halor player_hoke = new Halor(); // INSTANTIATE from Halor child class.
            player_hoke.provide_name();

            while (repeat_game == true) // While ITERATION to continue more battles.
            {

                newBattleObject.request_challenge(player_hoke);

                // INSTANTIATION of new Hokemon.
                /*
                Hokemon hoke01 = new Hokemon(); // INSTANTIATE new Hokemon object referred to as hoke01.name.
                hoke01.get_stats();

                Console.WriteLine("\n");

                Hokemon hoke02 = new Hokemon();
                hoke02.get_stats();

                Console.WriteLine("\n");

                
                // Team Hinstinct.
                Hinstinct hoke03 = new Hinstinct(); // INSTANTIATE from Hokemon Parent Class.

                // Team Halor.
                Halor halor_hoke01 = new Halor(); //INSTANTIATE from Halor Child Class.
                halor_hoke01.get_stats();

                // Demonstrating an example of POLYMORPHISM.
                hoke03.definition();
                halor_hoke01.definition();
                */
                

                // INSTANTIATING the battle.
                newBattleObject.the_battle(player_hoke, challengers[rnd.Next(0, challengers.Length)]);

                player_hoke.get_stats();

                Console.WriteLine("Do you want another battle? (y/n)");
                result = Console.ReadLine();

                if ((result.ToLower())[0] == 'n')
                {
                    repeat_game = false;
                }
            }
        }
    }
}
