# BlackjackCS

## P - Problem

- The goal of this assignment is to be able to play hands of blackjack. The user is the only human player and the dealer is the computer. We are using a 52 card deck with Aces being equal to 11.
  The user and the dealer are dealt a hand with 2 cards each. The user decides whether to hit (get another card) or stand (total the cards that they currently have). If the user goes over 21, they automatically lose. If they are under 21, the dealer reveals their hand and performs the same process. The dealer must hit if their total is less than 17. Once the dealer's cards are greater than or equal to 17, they must stand. Ultimately, whoever is closer to 21, wins and the terminal will display who won, however ties will always go to the dealer. A new game shuffles the deck and re-deals the cards.

## E - Examples

- The user started with the 4 of clubs and the 5 of diamonds, but then hit once to get the ten of spades before standing. Then the dealer revealed the 8 of clubs and the ten of diamonds. The code determines that the user wins because they have 19 total, and the dealer has 18 total.

- User started with queen of hearts and two of spades, the user then hits and gets a 7 of clubs. The user hits again and gets a 5 of diamonds. The user then busts because they have 24, they are now over 21.

- The user gets a 10 of clubs and a 6 of diamonds and stands. The dealer gets an 8 of hearts and a two of spades, then hits and gets a king of diamonds. The dealer then stands and wins because they have the total closer to 21.

- The user gets a 10 and a jack and stands. The dealer gets a king and a queen and stands. The dealer wins because the dealer will always take the win if tied.

- The user gets a 8 of diamonds and a jack and stands. The dealer gets a 10 and a five. The dealer then hits, and gets an 8 and busts because he is at 23, over 21. The user then wins.

- The user gets an ace and a 10 and stands. The dealer gets a queen and an 8 and stands. The user wins because they total 21 whereas the dealer totals 18.

## D - Data Structure

- Card class:

  Properties:
  Faces (Ace, 2, 3, jack, queen, etc.)
  Suits (diamonds, clubs, hearts, and spades)

  Methods: Value() - will determine the numeric value for the card (for example ace = 11, jack = 10, 8 = 8).

- Player class:

  Properties:
  Name(User or dealer)
  HandTotal

  Methods:
  Hit()
  Stand()

- Deck class:

  Properties:
  ListOfAllFaces
  ListOfAllSuits
  Cards

  Methods:
  GenerateNewDeck()
  ShuffleDeck()
  DealCards()

## A - Algorithm

- Generate a new deck of 52 cards by creating a card of each suit for each face

- Shuffle the new deck of cards using the "fisher yates modern shuffle technique"

- Deal the first two cards from the deck to the user

- Deal the next two cards from the deck to the dealer

- The user chooses to hit or stand

- If the user hits, they get dealt another card

- If the users total is over 21, they automatically lose

- If the users total is under 21, they choose to hit or stand

- If the user stands, it is the dealers turn

- If the dealers cards total is below 17, the dealer hits

- If the dealers cards total is greater than or equal to 17, the dealer stands

- If the dealers total goes over 21, the dealer automatically loses

- Once the player and the dealer have both stood, the hand closer to 21 wins
- Ties go to the dealer

- The user can start a new game or exit the program

- If the user starts a new game, a new deck is generated and shuffled and new hands are dealt to the players

## C - Code
