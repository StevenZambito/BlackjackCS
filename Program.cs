using System;
using System.Collections.Generic;

namespace BlackjackCS
{
    class Player
    {
        public string Name { get; set; }
        public List<string> Hand { get; set; }
        public int HandTotal { get; set; }
        public void Hit(Deck deck)
        {
            var newCard = deck.DeckOfCards[0];
            deck.DeckOfCards.RemoveAt(0);

            Hand.Add(newCard);
        }
        public void Stand()
        {
            Console.WriteLine("Standinggg");
        }

        public void CalculateHandTotal()
        {
            Console.WriteLine("calculating hand total");
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


        } */

    class Deck
    {
        public List<string> DeckOfCards { get; set; }

        public void GenerateNewDeck()
        {
            DeckOfCards = new List<string>();

            var ranks = new List<string>() { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };
            var suits = new List<string>() { "Clubs", "Diamonds", "Hearts", "Spades" };

            for (var i = 0; i < ranks.Count; i++)
            {
                for (var j = 0; j < suits.Count; j++)
                {
                    DeckOfCards.Add($"{ranks[i]} of {suits[j]}");
                }
            }
        }

        public void ShuffleDeck()
        {
            for (var i = DeckOfCards.Count - 1; i > 0; i--)
            {
                var randomNumber = new Random().Next(i - 1);
                var leftCard = DeckOfCards[randomNumber];
                var rightCard = DeckOfCards[i];

                DeckOfCards[randomNumber] = rightCard;
                DeckOfCards[i] = leftCard;
            }
        }

        public void DealCards(Player player)
        {
            var firstCard = DeckOfCards[0];
            DeckOfCards.RemoveAt(0);
            var secondCard = DeckOfCards[0];
            DeckOfCards.RemoveAt(0);

            player.Hand.Add(firstCard);
            player.Hand.Add(secondCard);
        }
    }

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

        static string PromptForHitOrStandString(string prompt)
        {
            Console.Write(prompt);
            var userInput = Console.ReadLine();

            return userInput;
        }
        static void Main(string[] args)
        {
            DisplayGreeting();

            var name = PromptForString("What is your name? ");

            var userPlayer = new Player()
            {
                Name = name,
                Hand = new List<string>(),
                HandTotal = 0
            };

            var dealerPlayer = new Player()
            {
                Name = "Dealer",
                Hand = new List<string>(),
                HandTotal = 0
            };

            var newDeckOfCards = new Deck();
            newDeckOfCards.GenerateNewDeck();

            foreach (string element in newDeckOfCards.DeckOfCards)
            {
                Console.WriteLine(element);
            }

            newDeckOfCards.ShuffleDeck();

            foreach (string element in newDeckOfCards.DeckOfCards)
            {
                Console.WriteLine(element);
            }

            newDeckOfCards.DealCards(userPlayer);
            newDeckOfCards.DealCards(dealerPlayer);
            Console.WriteLine("Here is your hand:");

            foreach (string element in userPlayer.Hand)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("");

            // foreach (string element in dealerPlayer.Hand)
            // {
            //     Console.WriteLine(element);
            // }
            var hitOrStand = PromptForHitOrStandString("Hit or stand?");

            if (hitOrStand == "Hit")
            {
                userPlayer.Hit(newDeckOfCards);
            }




        }
    }
}
