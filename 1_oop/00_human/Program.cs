using System;

namespace _00_human
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    // ==================================================================================
    // ==================================================================================
    // ==================================================================================
    // ==================================================================================
    // ==================================================================================
    // ==================================================================================
    // ==================================================================================
    // ==================================================================================
    class Human
    {
        // Fields for Human
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;

        // 1. Add an additional private field for health (int), 
        //    and a public property to access or "get" health
        private int Health;
        public int health_prop
        {
            get
            {
                return Health;
            }
        }
        
        // 2. Add a constructor method that takes a string to initialize Name - 
        //    and that will initialize Strength, Intelligence, and Dexterity to a default value of 3, 
        // and health to default value of 100
        public Human(string name)
        {
            Name = name;
            Strength = 3;
            Intelligence = 3;
            Health = 100;
        }

        // 3. Let's create an additional constructor that accepts 5 parameters, 
        //    so we can set custom values for every field.
        public Human(string name, int strength, int intelligence, int dexterity, int health)
        {
            Name = name;
            Strength = strength;
            Intelligence = intelligence;
            Dexterity = dexterity;
            Health = health;
        }

        // 4. -Add a new method called Attack, which when invoked, 
        //     should reduce the health of a Human object that is passed as a parameter. 
        //    -The damage done should be 5 * strength 
        //     (5 points of damage to the attacked, for each 1 point of strength of the attacker). 
        //    -This method should return the remaining health of the target object.
        public int Attack(Human target)
        {
            // Reduce the health of a Human object that is passed as a parameter
            target.Health -= 5*target.Strength;
            return target.Health;
        }
       
    }  
    // ==================================================================================
    // ==================================================================================
    // ==================================================================================
    // ==================================================================================
    // ==================================================================================
    // ==================================================================================
    // ==================================================================================
    // ==================================================================================
}
