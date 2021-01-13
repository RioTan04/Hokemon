using System;
using System.Collections.Generic;
using System.Text;

namespace Hokemon
{
    class Hokemon
    {
        // Hokemon Attributes.
        private string name;
        private int max_health;
        private int health;
        private int attack;
        private int special_attack;
        private int defense;
        private int special_defense;
        private int speed;

        // Below is my CONSTRUCTOR method for the Hokemon.
        public Hokemon()
        {
            provide_name();
            max_health = random_int_generator(10, 100);
            health = max_health;
            attack = random_int_generator(10, 100);
            special_attack = random_int_generator(10, 100);
            speed = random_int_generator(10, 100);
            defense = random_int_generator(10, 100);
            special_defense = random_int_generator(10, 100);
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Health
        {
            get { return health; }
            set { health = value; }
        }

        public void get_stats()
        {
            Console.WriteLine("\n##########################");
            Console.WriteLine(String.Format("# Name: {0,-10}       #", name));
            Console.WriteLine(String.Format("# Health: {0}/{1,-10}  #", health, max_health));
            Console.WriteLine(String.Format("# Attack: {0,-10}     #", attack));
            Console.WriteLine(String.Format("# Sp.Attack: {0,-10}  #", special_attack));
            Console.WriteLine(String.Format("# Speed: {0,-10}      #", speed));
            Console.WriteLine(String.Format("# Defense: {0,-10}    #", defense));
            Console.WriteLine(String.Format("# Sp.Defense: {0,-10} #", special_defense));
            Console.WriteLine("##########################");
        }

        public void provide_name()
        {
            Console.WriteLine("Enter a name for your Hokemon: ");
            name = Console.ReadLine();
        }

        public int random_int_generator(int min_value, int max_value) // PARAMETERS
        {
            Random rnd = new Random();

            int random_value;

            random_value = rnd.Next(min_value, max_value);
            
            return random_value;
        }
    }
}
