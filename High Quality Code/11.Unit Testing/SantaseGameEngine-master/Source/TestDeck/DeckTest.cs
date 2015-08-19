using System;
using NUnit.Framework;
using Santase.Logic.Extensions;
using System.Collections.Generic;
using Santase.Logic.Cards;
using Santase.Logic;

namespace TestDeck
{
    [TestFixture]

    public class DeckTest
    {
        [Test]
        public void TestCountOfCardsInNewDeckInstanceIsGreaterThanZero()
        {
            Deck gameDeck = new Deck();
            int initialCardsCount = gameDeck.CardsLeft;
            Assert.Greater(initialCardsCount, 0);
        } 

        [Test]
        [TestCase(25)]
        [TestCase(30)]
        [ExpectedException(typeof(InternalGameException))]
        public void GetNextCardThrowsAfterTakeCardFromEmptyDeck(int count)
        {
            var deck = new Deck();
            for (int i = 0; i < count; i++)
            {
                deck.GetNextCard();
            }
        }



        [Test]
        public void GetTrumpCardToReturnTheLastCardInTheDeck()
        {
            var deck = new Deck();
            var trumpCard = deck.GetTrumpCard;
            int length = deck.CardsLeft;
            Card card = new Card(CardSuit.Club, CardType.Ten);
            for (int i = 0; i < length; i++)
            {
                card = deck.GetNextCard();
            }

            Assert.AreEqual(trumpCard, card);
        }

        [Test]
        public void GetTheCardsCountLeftInTheDeck()
        {
            var deck = new Deck();
            int cardsRemovedFromTheDeck = 2;
            int targetNumberOfCards = 22;
            for (int i = 0; i < cardsRemovedFromTheDeck; i++)
            {
                deck.GetNextCard();
            }

            Assert.AreEqual(deck.CardsLeft, targetNumberOfCards);
        }

        [Test]
        [TestCase(CardType.Ace,CardSuit.Club)]

        public void TestChangeTrumpCardToProperlyUpdateTheDeck(CardType type, CardSuit suit) 
        {
             Card newCard = new Card(suit, type);
             Deck deck = new Deck();
             int deckLength = deck.CardsLeft;
             deck.ChangeTrumpCard(newCard);
             Card finalCard = new Card(CardSuit.Heart, CardType.Jack);
             for (var i = 0; i < deckLength - 1; i++)
             {
                 deck.GetNextCard();
                 if (i == deckLength - 2)
                 {
                     finalCard = deck.GetNextCard();
                 }
             }

             Assert.AreEqual(finalCard, newCard);
        }
    }
}


