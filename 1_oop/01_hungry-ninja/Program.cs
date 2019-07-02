using System;
using System.Collections.Generic;

namespace _01_hungry_ninja
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create food objects to feed ninja

            // Create Ninja object
            Ninja ninja = new Ninja();
            
            // Create Buffet object
            Buffet buffet = new Buffet();

            // Feed the ninja
            while(!ninja.isFull())
            {
                dynamic food = buffet.Serve();
                Console.WriteLine($"food from buffet is: {food.get_name()}");

                ninja.Eat(food);
            }
            Console.WriteLine($"Ninja is full and is going to go on a jog to burn off some calories!");
        }
        // ==================================================================================
        // ==================================================================================
        // ==================================================================================
        // ==================================================================================
        // ==================================================================================
        // ==================================================================================
        // ==================================================================================
        // ==================================================================================
        // 1. Create a Food class
        class Food
        {
            public string Name;
            public int Calories;
            public bool IsSpicy;
            public bool IsSweet;

            public Food(string name, int calories, bool isSpicy, bool isSweet)
            {
                Name = name;
                Calories = calories;
                IsSpicy = isSpicy;
                IsSweet = isSweet;
            }

            public string get_name() { return Name; }
        }

        // 2. Create a Buffet class, which will contain a Menu of Food objects
        class Buffet
        {
            public List<Food> Menu;

            // 3. Add a constructor and set Menu to a hard coded list of 7 
            //    or more Food objects you instantiate manually
            public Buffet()
            {
                // Set menu to a list of 7 food objects
                Menu = new List<Food>()
                {
                    new Food("apple",     100, false, true),
                    new Food("pepper",    100, true, false),
                    new Food("pizza",     800, false, false),
                    new Food("banana",    100, false, true),
                    new Food("chicken",   300, true, false),
                    new Food("hamburger", 400, false, false),
                    new Food("chilli",    500, true, false)
                };
            } // Buffet constructor

            // -4. Serve method randomly selects a Food object 
            //     from the Menu list and returns the Food object
            public Food Serve()
            {
                Random rand = new Random();

                // Return random menu object
                int N = Menu.Count;
                return Menu[rand.Next(0,N)];
            } // Serve constructor
        }

        // 5. Create Ninja class
        class Ninja
        {
            private int caloriesIntake;
            public List<Food> FoodHistory;

            // 6. Add a constructor that sets calorieIntake to 0 and creates a new, empty list of Food objects to FoodHistory
            public Ninja()
            {
                caloriesIntake = 0;
                FoodHistory = new List<Food>();
            }

            // 7. Add a public "getter" property called "isFull" that returns a boolean 
            //    based if the Ninja's calorie intake is greater than 1200 calories
            public Boolean isFull()
            {
                if (caloriesIntake > 1200)
                    return true;
                else
                    return false;
            }

            // 8. Build out the Eat method that: 
            //      -if the Ninja is NOT full:
            //          --Adds calorie value to ninja's total calorie intake
            //          --Adds the randomly selected Food object to ninja's FoodHistory list
            //          --Writes the Food's Name - and if it is spicy/sweet to the console
            //      -if the Ninja IS full:
            //          --issues a warning to the console that thte ninja is full and cannot eat anymore
            public void Eat(Food food)
            {
                if (!isFull())
                {
                    // Add calorie value to ninja's total calorie intake
                    caloriesIntake += food.Calories;

                    // Add the randomly selected Food object to ninja's FoodHistory list
                    FoodHistory.Add(food);

                    Console.WriteLine($"The ninja ate the {food.get_name()} and now has cumalative calorie intake of {caloriesIntake}");
                }
                else
                {
                    Console.WriteLine($"The ninja is FULL with a cumalative calorie intake of {caloriesIntake}");
                }
            }
        }
    }
}