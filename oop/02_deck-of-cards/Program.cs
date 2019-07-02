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
            card.stringVal = "Ace";      // set                         
            card.stringSuite = "Heart";  // set
            Console.WriteLine($"The card is {card.stringVal} of {card.stringSuite}"); // get
        }
    }
    //=========================================================================
    // Create a class called "Card"
    class Card
    {
        string Value;
        string Suite;

        // Give the card class a property "stringVal" which will hold the value of the card
        // (Ace, 2, 3, ..., 10, Jack, Queen, King)
        public string stringVal
        {
            get { return Value; }
            set { Value = value; }
        }

        // Give the Card a property "suit" which will hold the suit of the card
        public string stringSuite
        {  
            get { return Suite; }
            set { Suite = value; }
        }
    }

    
}
