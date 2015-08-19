using System;
using System.Collections.Generic;

namespace Poker
{
    public class PokerHandsChecker : IPokerHandsChecker
    {
        const int NumberOfSuits = 4;
        const int NumberOfCardsInHand = 5;
        public bool IsValidHand(IHand hand)
        {
            int countOfCards = hand.Cards.Count;
            if (countOfCards != NumberOfCardsInHand)
            {
                return false;
            }

            for (var i = 0; i < countOfCards; i++)
            {
                if (hand.Cards[i] == null)
                {
                    throw new ArgumentException("Card should not be NULL!");
                }
                for (var j = 0; j < countOfCards; j++)
                {
                    if (i != j)
                    {
                        if (hand.Cards[i].Face == hand.Cards[j].Face &&
                            hand.Cards[i].Suit == hand.Cards[j].Suit)
                        {
                            return false;                            
                        }
                    }
                }              
            }

            return true;
        }

        public bool IsStraightFlush(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsFourOfAKind(IHand hand)
        {
            if (!this.IsValidHand(hand))
            {
                return false;
            }
           
            Dictionary<CardFace, int> faces = new Dictionary<CardFace, int>();
            for (var i = 0; i < NumberOfCardsInHand; i++)
            {
                if (!faces.ContainsKey(hand.Cards[i].Face))
                {
                    faces.Add(hand.Cards[i].Face, 1);
                }
                else
                {
                    faces[hand.Cards[i].Face] = faces[hand.Cards[i].Face] + 1;
                }
            }

            if (faces.Count == 2 && faces.ContainsValue(4) && faces.ContainsValue(1) && faces.Count == 2)
               
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsFullHouse(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsFlush(IHand hand)
        {
            if (!this.IsValidHand(hand))
            {
                return false;
            }
            
            string checkString = hand.ToString();
            int[] checkPlaces = new int[NumberOfSuits];
            checkPlaces[0] = checkString.IndexOf("Hearts");
            checkPlaces[1] = checkString.IndexOf("Clubs");
            checkPlaces[2] = checkString.IndexOf("Spades");
            checkPlaces[3] = checkString.IndexOf("Diamonds");
            int countOfSuits = 0;
            for (var i = 0; i < NumberOfSuits; i++)
            {
                if (checkPlaces[i] != -1)
                {
                    countOfSuits++;
                }
            }

            if (countOfSuits == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsStraight(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsThreeOfAKind(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsTwoPair(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsOnePair(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsHighCard(IHand hand)
        {
            throw new NotImplementedException();
        }

        public int CompareHands(IHand firstHand, IHand secondHand)
        {
            throw new NotImplementedException();
        }
    }
}
