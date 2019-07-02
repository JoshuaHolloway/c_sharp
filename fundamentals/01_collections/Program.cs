using System;
using System.Collections.Generic;

namespace _01_collections
{
    class Program
    {
        static void Main(string[] args)
        {
                        // Part-1: Three Basic Arrays
            // 1.a Create an array to hold integer values 0 through 9
            uint[] arr = new uint[10];
            for (uint i = 0; i <= 9; ++i)
                arr[i] = i;

            // 1.b Create an array of the names "Tim", "Martin", "Nikki", & "Sara"
            string[] names = {"Tim", "Martin", "Nikki", "Sara"};

            // 1.c Create an array of length 10 that alternates between true and false values, starting with true
            bool[] array = new bool[10];
            for (uint i = 0; i < 10; ++i)
            {
                if(i % 2 == 0)
                    array[i] = true;
                else
                    array[i] = false;
            }

            // Part-2: List of Flavors
            // 2.a Create a list of ice cream flavors that holds at least 5 different flavors (feel free to add more than 5!)
            List<string> flavors = new List<string>();
            flavors.Add("Vanilla");
            flavors.Add("Chocolate");
            flavors.Add("Rocky-Road");
            flavors.Add("Strawberry");
            flavors.Add("Hot-Dog Flavor");

            // 2.b Output the length of this list after building it
            Console.WriteLine($"There are {flavors.Count}-number of flavors");

            // 2.c Output the third flavor in the list, then remove this value
            Console.WriteLine($"The 3d element in the list is: {flavors[2]}");
            flavors.RemoveAt(2);

            // 2.d Output the new length of the list (It should just be one fewer!)
            Console.WriteLine($"After removing one element from the list the number of flavors is {flavors.Count} and the stored values are:");
            foreach (string flavor in flavors)
                Console.WriteLine(flavor);

            // Par-3: User Info Dictionary
            // 3.a Create a dictionary that will store both string keys as well as string values
            Dictionary<string, string> dict = new Dictionary<string, string>();

            // 3.b Add key/value pairs to this dictionary where:
            //  3.b.1 each key is a name from your names array
            //  3.b.2 each value is randomly select a flavor from your flavors list.
            Random rand = new Random();
            int N = flavors.Count;
            dict.Add(names[0], flavors[rand.Next(0,N)]);
            dict.Add(names[1], flavors[rand.Next(0,N)]);
            dict.Add(names[2], flavors[rand.Next(0,N)]);
            dict.Add(names[3], flavors[rand.Next(0,N)]);

            // 3.e Loop through the dictionary and print out each user's name and their associated ice cream flavor
            foreach(KeyValuePair<string,string> entry in dict)
                Console.WriteLine(entry.Key + " - " + entry.Value);
        }
    }
}
