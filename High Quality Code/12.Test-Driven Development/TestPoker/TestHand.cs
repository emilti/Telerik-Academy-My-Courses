using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Poker;
using System.Collections.Generic;

namespace TestPoker
{
    /// <summary>
    /// Test the toString Method of hand to return the expected output.
    /// </summary>
    [TestClass]
    public class TestHand
    {
        [TestMethod]
        public void TestHandToStringToReturnStringWIthCardsFromTheHand()
        {
            Card firstCard = new Card(CardFace.Ace, CardSuit.Clubs);
            Card secondCard = new Card(CardFace.Ace, CardSuit.Diamonds);
            Card thirdCard = new Card(CardFace.Ace, CardSuit.Hearts);
            Card fourthCard = new Card(CardFace.Ace, CardSuit.Spades);
            Card fifthCard = new Card(CardFace.King, CardSuit.Hearts);
            List<ICard> Cards = new List<ICard>(new ICard[]{ firstCard, secondCard, thirdCard, fourthCard, fifthCard });
            Hand myHand = new Hand(Cards);
            string checkString = CardFace.Ace + " of " + CardSuit.Clubs + Environment.NewLine + 
                CardFace.Ace + " of " + CardSuit.Diamonds + Environment.NewLine + 
                CardFace.Ace + " of " + CardSuit.Hearts + Environment.NewLine +
                CardFace.Ace + " of " + CardSuit.Spades + Environment.NewLine + 
                CardFace.King + " of " + CardSuit.Hearts;
            Assert.AreEqual(myHand.ToString().CompareTo(checkString), 0);      
        }
    }
}
