using System;
using System.Collections.Generic;

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
    class Card
    {
        int Numeric_Value;
        string Value;
        string Suite;
        //---------------------------------------------------------------------
        // Give the card class a property "stringVal" which will hold the value of the card
        // (Ace, 2, 3, ..., 10, Jack, Queen, King)
        public string stringVal
        {
            get { return Value; }
            set { Value = value; }
        }
        //---------------------------------------------------------------------
        // Give the Card a property "suit" which will hold the suit of the card
        public string stringSuite
        {  
            get { return Suite; }
            set { Suite = value; }
        }
        //---------------------------------------------------------------------
        // Give the Card a property "val" which will hold the numerical value of the card 1-13 as integers
        public int val
        {
            get { return Numeric_Value; }
            set
            {
                switch (Value)
                {
                    case "Ace":
                        Numeric_Value = 1;
                        break;
                    default:
                        Console.WriteLine("This is how we do case statements");
                        break;
                }
            }
        }
    }
    //=========================================================================
    public class Deck
    {       
        // 1. Give Deck a property called "cards" which is a list of Card objects.
        //---------------------------------------------------------------------
        // 2. When initializing the deck, make sure that it has a list of 52 unique cards as its "cards" property.
        //---------------------------------------------------------------------
        // 3. Give the Deck a deal method that selects the "top-most" card, removes it from the list of cards, and returns the Card.
        //---------------------------------------------------------------------
        // 4. Give the Deck a reset method that resets the cards property to contain the original 52 cards.
        //---------------------------------------------------------------------
        // 5. Give the Deck a shuffle method that randomly reorders the deck's cards.
        //---------------------------------------------------------------------

    }
    //=========================================================================
    public class Player
    {
        // 1. Give Player a name property
        string name;

        // 2. Give Player a hand property that is a List of type Card
        List<Card> Hand = new List<Card>();

        // 3. Give Player a draw method of which draws a card from a deck, 
        //    adds it  to the player's hand and returns the Card.



        //      --This will require a reference to a deck object

        // 4. Give Player a discard method which discards the Card at the 
        //    specified index from the player's hand and returns this Card 
        //    or null if the index does not exist.
    }
}
