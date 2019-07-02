using System;

namespace _02_deck_of_cards
{
    //=========================================================================
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Card card = new Card();

            // Demonstrating using property
            card.stringVal = "Ace";                              // set
            Console.WriteLine($"The value is {card.stringVal}"); // get
        }
    }
    //=========================================================================
    // Create a class called "Card"
    class Card
    {
        string Value;

        // Give the card class a property "stringVal" which will hold the value of the card
        // (Ace, 2, 3, ..., 10, Jack, Queen, King)
        public string stringVal
        {
            get { return Value; }
            set { Value = value; }
        }
    }
}
