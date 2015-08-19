namespace TestPoker
{
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Poker;
    /// <summary>
    /// Summary description for TestIsFlush
    /// </summary>
    [TestClass]
    public class TestIsFlush
    {
        private PokerHandsChecker handTester = new PokerHandsChecker();
        [TestMethod]
        public void TestIsFlushFiveCardsfromOneSuitShouldReturnTrue()
        {
            Card firstCard = new Card(CardFace.Ace, CardSuit.Clubs);
            Card secondCard = new Card(CardFace.King, CardSuit.Clubs);
            Card thirdCard = new Card(CardFace.Queen, CardSuit.Clubs);
            Card fourthCard = new Card(CardFace.Jack, CardSuit.Clubs);
            Card fifthCard = new Card(CardFace.Ten, CardSuit.Clubs);
            List<ICard> Cards = new List<ICard>(new ICard[] { firstCard, secondCard, thirdCard, fourthCard, fifthCard });
            Hand myHand = new Hand(Cards);
            Assert.AreEqual(true, handTester.IsFlush(myHand));
        }
      
        [TestMethod]
        public void TestIsFlushCardsfromDifferentSuitsShouldReturnFalse()
        {
            Card firstCard = new Card(CardFace.Ace, CardSuit.Clubs);
            Card secondCard = new Card(CardFace.King, CardSuit.Hearts);
            Card thirdCard = new Card(CardFace.Queen, CardSuit.Clubs);
            Card fourthCard = new Card(CardFace.Jack, CardSuit.Clubs);
            Card fifthCard = new Card(CardFace.Ten, CardSuit.Hearts);
            List<ICard> Cards = new List<ICard>(new ICard[] { firstCard, secondCard, thirdCard, fourthCard, fifthCard });
            Hand myHand = new Hand(Cards);
            Assert.AreEqual(false, handTester.IsFlush(myHand));
        }

        [TestMethod]
        public void TestIsFlushInvalidHandShouldReturnFalse()
        {
            Card firstCard = new Card(CardFace.Ace, CardSuit.Clubs);
            Card secondCard = new Card(CardFace.King, CardSuit.Hearts);
            Card thirdCard = new Card(CardFace.Queen, CardSuit.Clubs);
            Card fourthCard = new Card(CardFace.Jack, CardSuit.Clubs);
            Card fifthCard = new Card(CardFace.Ace, CardSuit.Clubs);
            List<ICard> Cards = new List<ICard>(new ICard[] { firstCard, secondCard, thirdCard, fourthCard, fifthCard });
            Hand myHand = new Hand(Cards);
            Assert.AreEqual(false, handTester.IsFlush(myHand));
        } 
    }
}
