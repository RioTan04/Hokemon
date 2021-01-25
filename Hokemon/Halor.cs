using System;
using System.Collections.Generic;
using System.Text;

namespace Hokemon
{
    class Halor : Hokemon // INHERITING from Hokemon BASS CLASS.
    {
        public Halor() //Halor CONSTRUCTOR method
        {
            Team = "Halor"; // using Team property to assign value.
        }

        
        public void definition()
        {
            Console.WriteLine("I am {0} and I am part the ferocious Halor Tribe!!", Name);
        }
        
    }
}
