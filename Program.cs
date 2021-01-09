using System;

namespace BlackjackCS
{
    class Player
    {
        public string Name { get; set; }
        public int HandTotal { get; set; }

        public void Hit()
        {
            Console.WriteLine("Hittting");
        }

        public void Stand()
        {
            Console.WriteLine("Standinggg");
        }


    }
    /*
        class Card
        {
            public string Faces { get; set; }
            public string Suits { get; set; }

            public int Value()
            {

            }


        }

        class Deck
        {
            public string ListOfAllFaces { get; set; }

            public string listOfAllSuits { get; set; }

            public string cards { get; set; }

            GenerateNewDeck()
            {

            }

            ShuffleDeck()
            {

            }

            DealCards()
            {

            }


        }
        */

    class Program

    {
        static void DisplayGreeting()
        {
            Console.WriteLine("Welcome to BlackJack!");
        }

        static string PromptForString(string prompt)
        {
            Console.Write(prompt);
            var userInput = Console.ReadLine();
            return userInput;
        }
        static void Main(string[] args)
        {
            DisplayGreeting();

            var name = PromptForString("What is your name? ");
            Console.WriteLine(name);

        }
    }
}
