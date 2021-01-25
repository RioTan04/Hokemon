using System;
using System.Collections.Generic;
using System.Text;

namespace Hokemon
{
    class Battle_Arena
    {
        public void request_challenge(Hokemon requestor)
        {
            Console.WriteLine("{0}: says 'I want a battle!'", requestor.Name);
        }

        public void the_battle(Hokemon attacker, Hokemon defender)
        {
            int round = 0;
            int attack_value;
            int defense_value;
            Hokemon tempHoke;

            Console.WriteLine("{0}: waits...", attacker.Name);
            System.Threading.Thread.Sleep(2000); // Wait statement for 2 seconds
            Console.WriteLine("{0}: and waits...", attacker.Name);
            System.Threading.Thread.Sleep(2000); // Wait statement for 2 seconds
            Console.WriteLine("{0}: 'I accept the challenge!'", defender.Name);

            Console.WriteLine("\n*** Constender Stats ***");
            attacker.get_stats();
            defender.get_stats();

            Console.WriteLine("\n*** BATTLE BEGINS ***\n");

            while (Convert.ToInt32(defender.Health) >= 0 || Convert.ToInt32(attacker.Health) >= 0)
            {
                round += 1;
                attack_value = attacker.attack_calculator();
                defense_value = defender.defense_calculator();

                Console.WriteLine("*** Round {0} ***\n", round);

                for (int i = 0; i < 2; i++)
                {
                    Console.WriteLine("\n**********************************\n");

                    System.Threading.Thread.Sleep(2000); // Wait statement for 2 seconds
                    Console.WriteLine("{0}: Prepares for an attack...", attacker.Name);

                    System.Threading.Thread.Sleep(2000); // Wait statement for 2 seconds
                    Console.WriteLine("{0}: Attack value: {1}...", attacker.Name, attack_value);

                    System.Threading.Thread.Sleep(2000); // Wait statement for 2 seconds
                    Console.WriteLine("{0}: Swiftly moves and creates a defense value of: {1}", defender.Name, defense_value);

                    defender.Health = (defender.Health + defense_value) - attack_value;

                    System.Threading.Thread.Sleep(2000); // Wait statement for 2 seconds
                    Console.WriteLine("{0}: New HEALTH value: {1} ", defender.Name, ((defender.Health + defense_value) - attack_value));

                    Console.WriteLine("\n**********************************\n");

                    // Example of how OBJECTS can be switched identifier names
                    // This saves on having to repeat code
                    Console.WriteLine("\n****\nSwitch turns: Defender becomes the Attacker...\n****\n");
                    tempHoke = attacker;
                    attacker = defender;
                    defender = tempHoke;
                }
            }
            if (defender.Health <= 0)
            {
                Console.WriteLine("{0}: WINS", attacker.Name);  // Produces a LOGICAL error - why??
            }
        }
    }
}
