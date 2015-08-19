namespace TestPoker
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Poker;
    using System.Collections.Generic;
    
    /// <summary>
    /// Test if the hands passed to the PokerHandsChecker are valid according to the poker rules.
    /// </summary>
    [TestClass]
    public class TestValidHand
    {
        private PokerHandsChecker handTester = new PokerHandsChecker();

        [TestMethod]

        public void TestPokerHandsCheckToReturnTrueIfValidHandIsPassed()
        {            
            Card firstCard = new Card(CardFace.Ace, CardSuit.Clubs);
            Card secondCard = new Card(CardFace.Ace, CardSuit.Diamonds);
            Card thirdCard = new Card(CardFace.Ace, CardSuit.Hearts);
            Card fourthCard = new Card(CardFace.Ace, CardSuit.Spades);
            Card fifthCard = new Card(CardFace.King, CardSuit.Hearts);
            List<ICard> Cards = new List<ICard>(new ICard[] { firstCard, secondCard, thirdCard, fourthCard, fifthCard });
            IHand myHand = new Hand(Cards);
            Assert.AreEqual(true, handTester.IsValidHand(myHand));
        }
        
        [TestMethod]

        public void TestPokerHandsCheckToReturnFalseIfInValidCountOfCardsInHandIsPassed()
        {
            Card firstCard = new Card(CardFace.Ace, CardSuit.Clubs);
            Card secondCard = new Card(CardFace.Ace, CardSuit.Diamonds);
            Card thirdCard = new Card(CardFace.Ace, CardSuit.Hearts);
            Card fourthCard = new Card(CardFace.Ace, CardSuit.Spades);          
            List<ICard> Cards = new List<ICard>(new ICard[] { firstCard, secondCard, thirdCard, fourthCard });
            IHand myHand = new Hand(Cards);
            Assert.AreEqual(false, handTester.IsValidHand(myHand));
        }

        [TestMethod]

        public void TestPokerHandsCheckToReturnfalseIfinValidHandSecondRepeatedCardIsPassed()
        {
            Card firstCard = new Card(CardFace.Ace, CardSuit.Clubs);
            Card secondCard = new Card(CardFace.Ace, CardSuit.Clubs);
            Card thirdCard = new Card(CardFace.Ace, CardSuit.Hearts);
            Card fourthCard = new Card(CardFace.Ace, CardSuit.Spades);
            Card fifthCard = new Card(CardFace.King, CardSuit.Hearts);
            List<ICard> Cards = new List<ICard>(new ICard[] { firstCard, secondCard, thirdCard, fourthCard, fifthCard });
            IHand myHand = new Hand(Cards);
            Assert.AreEqual(false, handTester.IsValidHand(myHand));
        }

        [TestMethod]

        public void TestPokerHandsCheckToReturnfalseIfInValidHandRepeatedFifthCardIsPassed()
        {
            Card firstCard = new Card(CardFace.Ace, CardSuit.Clubs);
            Card secondCard = new Card(CardFace.Ace, CardSuit.Diamonds);
            Card thirdCard = new Card(CardFace.Ace, CardSuit.Hearts);
            Card fourthCard = new Card(CardFace.Ace, CardSuit.Spades);
            Card fifthCard = new Card(CardFace.Ace, CardSuit.Clubs);
            List<ICard> Cards = new List<ICard>(new ICard[] { firstCard, secondCard, thirdCard, fourthCard, fifthCard });
            IHand myHand = new Hand(Cards);
            Assert.AreEqual(false, handTester.IsValidHand(myHand));
        }    

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestPokerHandsCheckToReturnfalseIfInValidHandFiveNullIsPassed()
        {
            List<ICard> Cards = new List<ICard>(new ICard[] { null, null, null, null, null });
            IHand myHand = new Hand(Cards);
            Assert.AreEqual(false, handTester.IsValidHand(myHand));
        }       
    }
}
