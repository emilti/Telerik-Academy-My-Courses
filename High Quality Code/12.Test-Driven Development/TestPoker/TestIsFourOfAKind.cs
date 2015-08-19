namespace TestPoker
{
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Poker;
    /// <summary>
    /// Check hand to be four of a kind
    /// </summary>
    [TestClass]
    public class TestIsFourOfAKind
    {
        private PokerHandsChecker handTester = new PokerHandsChecker();
        [TestMethod]
        public void TestIsFourOfaKindInvalidHandShouldReturnFalse()
        {
            Card firstCard = new Card(CardFace.Ace, CardSuit.Clubs);
            Card secondCard = new Card(CardFace.Ace, CardSuit.Hearts);
            Card thirdCard = new Card(CardFace.Queen, CardSuit.Clubs);
            Card fourthCard = new Card(CardFace.Jack, CardSuit.Clubs);
            Card fifthCard = new Card(CardFace.Ace, CardSuit.Clubs);
            List<ICard> Cards = new List<ICard>(new ICard[] { firstCard, secondCard, thirdCard, fourthCard, fifthCard });
            Hand myHand = new Hand(Cards);
            Assert.AreEqual(false, handTester.IsFourOfAKind(myHand));
        }

        [TestMethod]
        public void TestIsFourOfaKindFourCardsfromOnefaceShouldReturnTrue()
        {
            Card firstCard = new Card(CardFace.Ace, CardSuit.Clubs);
            Card secondCard = new Card(CardFace.Ace, CardSuit.Hearts);
            Card thirdCard = new Card(CardFace.Ace, CardSuit.Spades);
            Card fourthCard = new Card(CardFace.Ace, CardSuit.Diamonds);
            Card fifthCard = new Card(CardFace.Ten, CardSuit.Clubs);
            List<ICard> Cards = new List<ICard>(new ICard[] { firstCard, secondCard, thirdCard, fourthCard, fifthCard });
            Hand myHand = new Hand(Cards);
            Assert.AreEqual(true, handTester.IsFourOfAKind(myHand));
        }

        [TestMethod]
        public void TestIsFourOfaKindValidHandNotFourCardsWithSameFaceShouldReturnFalse()
        {
            Card firstCard = new Card(CardFace.Ace, CardSuit.Clubs);
            Card secondCard = new Card(CardFace.Ace, CardSuit.Hearts);
            Card thirdCard = new Card(CardFace.Ace, CardSuit.Diamonds);
            Card fourthCard = new Card(CardFace.Ten, CardSuit.Clubs);
            Card fifthCard = new Card(CardFace.Ten, CardSuit.Hearts);
            List<ICard> Cards = new List<ICard>(new ICard[] { firstCard, secondCard, thirdCard, fourthCard, fifthCard });
            Hand myHand = new Hand(Cards);
            Assert.AreEqual(false, handTester.IsFourOfAKind(myHand));
        }
    }
}
