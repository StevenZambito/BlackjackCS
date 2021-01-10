using System;
using System.Collections.Generic;

namespace BlackjackCS
{
    class Player
    {
        public string Name { get; set; }
        public List<Card> Hand { get; set; }
        public int HandTotal { get; set; }
        public void Hit(Deck deck)
        {
            var newCard = deck.DeckOfCards[0];
            deck.DeckOfCards.RemoveAt(0);

            Hand.Add(newCard);

            CalculateHandTotal();

        }
        public void Stand()
        {
            CalculateHandTotal();
        }

        public int CalculateHandTotal()
        {
            var total = 0;
            foreach (var element in Hand)
            {
                total += element.Value();
            }
            HandTotal = total;
            return HandTotal;
        }

    }

    class Card
    {
        public string Rank { get; set; }
        public string Suit { get; set; }

        public int Value()
        {
            switch (Rank)
            {
                case "Ace":
                    return 11;
                case "2":
                    return 2;
                case "3":
                    return 3;
                case "4":
                    return 4;
                case "5":
                    return 5;
                case "6":
                    return 6;
                case "7":
                    return 7;
                case "8":
                    return 8;
                case "9":
                    return 9;
                case "10":
                    return 10;
                case "Jack":
                    return 10;
                case "Queen":
                    return 10;
                case "King":
                    return 10;
                default:
                    return 0;
            }
        }


    }

    class Deck
    {
        public List<Card> DeckOfCards { get; set; }

        public void GenerateNewDeck()
        {
            DeckOfCards = new List<Card>();

            var ranks = new List<string>() { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };
            var suits = new List<string>() { "Clubs", "Diamonds", "Hearts", "Spades" };

            for (var i = 0; i < ranks.Count; i++)
            {
                for (var j = 0; j < suits.Count; j++)
                {
                    DeckOfCards.Add(new Card()
                    {
                        Rank = ranks[i],
                        Suit = suits[j]
                    });
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
                Hand = new List<Card>(),
                HandTotal = 0
            };

            var dealerPlayer = new Player()
            {
                Name = "Dealer",
                Hand = new List<Card>(),
                HandTotal = 0
            };

            var newDeckOfCards = new Deck();
            newDeckOfCards.GenerateNewDeck();

            foreach (var element in newDeckOfCards.DeckOfCards)
            {
                Console.WriteLine(element);
            }

            newDeckOfCards.ShuffleDeck();

            foreach (var element in newDeckOfCards.DeckOfCards)
            {
                Console.WriteLine(element);
            }

            newDeckOfCards.DealCards(userPlayer);
            newDeckOfCards.DealCards(dealerPlayer);
            Console.WriteLine("Here is your hand:");

            foreach (var element in userPlayer.Hand)
            {
                Console.WriteLine(element.Rank + " of " + element.Suit);
            }
            Console.WriteLine("");

            // foreach (string element in dealerPlayer.Hand)
            // {
            //     Console.WriteLine(element);
            // }

            while (userPlayer.HandTotal < 21)
            {
                var hitOrStand = PromptForHitOrStandString("Hit or stand? ");


                if (hitOrStand == "Hit")
                {
                    userPlayer.Hit(newDeckOfCards);
                    if (userPlayer.HandTotal > 21)
                    {
                        Console.WriteLine("You bust, Game Over!");

                    }

                }
                else if (hitOrStand == "Stand")
                {
                    userPlayer.Stand();
                }
                foreach (var element in userPlayer.Hand)
                {
                    Console.WriteLine(element.Rank + " of " + element.Suit);
                }
            }



            Console.WriteLine(userPlayer.HandTotal);


        }
    }
}
