using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Poker;

namespace TestPoker
{
    /// <summary>
    /// Test cases for the possible toString results of the card class
    /// </summary>
    [TestClass]
    public class TestCard
    {
        [TestMethod]
       
        public void TestCardAceOfClubsToStringToReturnStrigWithCardFaceAceAndCardSuitClubs()
        {
            Card myCard = new Card(CardFace.Ace, CardSuit.Clubs);
            string targetToString = "Ace of Clubs";
            string myCardToString = myCard.Face + " of " + myCard.Suit;
            Assert.AreEqual(targetToString, myCardToString);
        }        

        [TestMethod]        
        public void TestCardKingOfDiamondsToStringToReturnStrigWithCardFaceKingAndCardSuitDiamonds()
        {
            Card myCard = new Card(CardFace.King, CardSuit.Diamonds);
            string targetToString = "King of Diamonds";
            string myCardToString = myCard.Face + " of " + myCard.Suit;
            Assert.AreEqual(targetToString, myCardToString);
        }

        [TestMethod]
        public void TestCardQueenOfHeartsToStringToReturnStrigWithCardFaceQueenAndCardSuitHearts()
        {
            Card myCard = new Card(CardFace.Queen, CardSuit.Hearts);
            string targetToString = "Queen of Hearts";
            string myCardToString = myCard.Face + " of " + myCard.Suit;
            Assert.AreEqual(targetToString, myCardToString);
        }

        [TestMethod]
        public void TestCardJackOfSpadesToStringToReturnStrigWithCardFaceJackAndCardSuitSpades()
        {
            Card myCard = new Card(CardFace.Jack, CardSuit.Spades);
            string targetToString = "Jack of Spades";
            string myCardToString = myCard.Face + " of " + myCard.Suit;
            Assert.AreEqual(targetToString, myCardToString);
        }

        [TestMethod]
        public void TestCardTenOfSpadesToStringToReturnStrigWithCardFaceTenAndCardSuitSpades()
        {
            Card myCard = new Card(CardFace.Ten, CardSuit.Spades);
            string targetToString = "Ten of Spades";
            string myCardToString = myCard.Face + " of " + myCard.Suit;
            Assert.AreEqual(targetToString, myCardToString);
        }

        [TestMethod]
        public void TestCardNineOfSpadesToStringToReturnStrigWithCardFaceNineAndCardSuitSpades()
        {
            Card myCard = new Card(CardFace.Nine, CardSuit.Spades);
            string targetToString = "Nine of Spades";
            string myCardToString = myCard.Face + " of " + myCard.Suit;
            Assert.AreEqual(targetToString, myCardToString);
        }

        [TestMethod]
        public void TestCardEightOfSpadesToStringToReturnStrigWithCardFaceEightAndCardSuitSpades()
        {
            Card myCard = new Card(CardFace.Eight, CardSuit.Spades);
            string targetToString = "Eight of Spades";
            string myCardToString = myCard.Face + " of " + myCard.Suit;
            Assert.AreEqual(targetToString, myCardToString);
        }

        [TestMethod]
        public void TestCardSevenOfSpadesToStringToReturnStrigWithCardFaceSevenAndCardSuitSpades()
        {
            Card myCard = new Card(CardFace.Seven, CardSuit.Spades);
            string targetToString = "Seven of Spades";
            string myCardToString = myCard.Face + " of " + myCard.Suit;
            Assert.AreEqual(targetToString, myCardToString);
        }

        [TestMethod]
        public void TestCardSixOfSpadesToStringToReturnStrigWithCardFaceSixAndCardSuitSpades()
        {
            Card myCard = new Card(CardFace.Six, CardSuit.Spades);
            string targetToString = "Six of Spades";
            string myCardToString = myCard.Face + " of " + myCard.Suit;
            Assert.AreEqual(targetToString, myCardToString);
        }

        [TestMethod]
        public void TestCardFiveOfSpadesToStringToReturnStrigWithCardFaceFiveAndCardSuitSpades()
        {
            Card myCard = new Card(CardFace.Five, CardSuit.Spades);
            string targetToString = "Five of Spades";
            string myCardToString = myCard.Face + " of " + myCard.Suit;
            Assert.AreEqual(targetToString, myCardToString);
        }

        [TestMethod]
        public void TestCardFourOfSpadesToStringToReturnStrigWithCardFaceFourAndCardSuitSpades()
        {
            Card myCard = new Card(CardFace.Four, CardSuit.Spades);
            string targetToString = "Four of Spades";
            string myCardToString = myCard.Face + " of " + myCard.Suit;
            Assert.AreEqual(targetToString, myCardToString);
        }

        [TestMethod]
        public void TestCardThreeOfSpadesToStringToReturnStrigWithCardFaceThreeAndCardSuitSpades()
        {
            Card myCard = new Card(CardFace.Three, CardSuit.Spades);
            string targetToString = "Three of Spades";
            string myCardToString = myCard.Face + " of " + myCard.Suit;
            Assert.AreEqual(targetToString, myCardToString);
        }


        [TestMethod]
        public void TestCardTwoOfSpadesToStringToReturnStrigWithCardFaceTwoAndCardSuitSpades()
        {
            Card myCard = new Card(CardFace.Two, CardSuit.Spades);
            string targetToString = "Two of Spades";
            string myCardToString = myCard.Face + " of " + myCard.Suit;
            Assert.AreEqual(targetToString, myCardToString);
        }
    }
}
