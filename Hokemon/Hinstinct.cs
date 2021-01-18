using System;
using System.Collections.Generic;
using System.Text;

namespace Hokemon
{
    class Hinstinct : Hokemon // INHERITING from Hokemon BASS CLASS.
    {
        public string team = "Hinstinct";

        public void definition()
        {
            Console.WriteLine("I am {0} and I am part the ferocious Hinstinct Tribe!!", Name);
        }
    }
}
