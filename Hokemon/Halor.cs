using System;
using System.Collections.Generic;
using System.Text;

namespace Hokemon
{
    class Halor : Hokemon // INHERITING from Hokemon BASS CLASS.
    {
        public string team = "Halor";

        public void definition()
        {
            Console.WriteLine("I am {0} and I am part the ferocious Halor Tribe!!", Name);
        }
    }
}
