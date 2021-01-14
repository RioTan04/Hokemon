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
            Console.WriteLine("{0}: waits...", attacker.Name);
            System.Threading.Thread.Sleep(2000); // Wait statement for 2 seconds
            Console.WriteLine("{0}: and waits...", attacker.Name);
            System.Threading.Thread.Sleep(2000); // Wait statement for 2 seconds
            Console.WriteLine("{0}: 'I accept the challenge!'", defender.Name);
        }
    }
}
