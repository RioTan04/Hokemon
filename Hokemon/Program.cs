using System;

namespace Hokemon
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Welcome to HokeWorld - Home of all Hokemon!");

            // INSTANTIATION of new Hokemon.

            Hokemon hoke01 = new Hokemon(); // INSTANTIATE new Hokemon object referred to as hoke01.name
            hoke01.get_stats();

            Console.WriteLine("\n");

            Hokemon hoke02 = new Hokemon();
            hoke02.get_stats();
        }
    }
}
