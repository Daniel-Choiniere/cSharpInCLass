USE BRANCH VERSION3.0

CODE REVIEW:
I am still getting the hang of building my classes, and working in an Object Oriented mindset, 
and would love to hear feedack on any thing I can do to improve my code.

The project is not complete at this stage. 
Run the app to start the game and a statndard playing card deck will be created. 
From there two players will be created with hands of 8 cards each.
For testing purposes, as of now the two decks are displayed in the console and each user gets a chance to pick a card to swap out.

I am currently working on implementing the exchange card method.
The issue that I am currently working on with that method is that I need to remove the card the user has chosen from their hand, 
and then draw a new card from the original deck.created

Will complete this weekend, Thanks for the review!

This project will be a version of a card game called Best Hand.
Best Hand V2. Aka Cliff's game

GAMEPLAY:
Allow for up to 5 rounds of play to occur. 
Players may exchange cards based on a set of rules. The values of a hand now can earn bonuses as well.
8 cards starting in hand
Can trade in all 8 as long as it follows the trade card rules

Trade card rules:
1. # of cards must follow fibonacci sequence
2. Can not trade in two cards of the same values
3. If trading more than 2 cards, 1 must be a 
    face card unless they do not have one
4. If deck runs out, shuffle discard pile back into play.

Scoring:
1. If any players have the same face card, 1 from each player is removed.
2. For each card with a match, +2 points
3. For each card in a straight of at least 3 cards, +3 points. 
    For each additional card, +3 points.
4. For each card in the royal family beyond the first, +5 
    best hand wins (total value)

