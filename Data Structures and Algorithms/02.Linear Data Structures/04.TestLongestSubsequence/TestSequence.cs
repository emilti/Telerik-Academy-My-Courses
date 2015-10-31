namespace LinearDataStructures
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.Collections.Generic;

    [TestClass]
    public class TestSequence
    {     

        [TestMethod]
        public void TestSearcherToCountTwoEqualNumbersAtTheEndAndReturnRightValue()
        {
            List<int> numbers = new List<int>();
            numbers = new List<int> { 2, 3, -2, -1, -1 };
            Sequence sequence = new Sequence();
            Searcher searcher = new Searcher();
            
            sequence = searcher.SearchLongestSequenceOfEqualNumbers(numbers, sequence);
            Assert.AreEqual(sequence.Length, 2);
            Assert.AreEqual(sequence.EqualNumber, -1);
        }

        [TestMethod]
        public void TestSearcherToCountThreeEqualNumbersAtTheBeginingAndReturnRightValue()
        {
            List<int> numbers = new List<int>();
            numbers = new List<int> {2, 2, 2, 3, -2, -1, -1 };
            Sequence sequence = new Sequence();
            Searcher searcher = new Searcher();
            sequence = searcher.SearchLongestSequenceOfEqualNumbers(numbers, sequence);
            Assert.AreEqual(sequence.Length, 3);
            Assert.AreEqual(sequence.EqualNumber, 2);
        }

        [TestMethod]
        public void TestSearcherToCountFourEqualNumbersAtTheEndAndReturnRightValue()
        {
            List<int> numbers = new List<int>();
            numbers = new List<int> { 2, 2, 2, 3, -2, -1, -1, -1, -1 };
            Sequence sequence = new Sequence();
            Searcher searcher = new Searcher();
            sequence = searcher.SearchLongestSequenceOfEqualNumbers(numbers, sequence);
            Assert.AreEqual(sequence.Length, 4);
            Assert.AreEqual(sequence.EqualNumber, -1);
        }

        [TestMethod]
        public void TestSearcherToCountOneNumbersAndReturnRightValue()
        {
            List<int> numbers = new List<int>();
            numbers = new List<int> { 2 };
            Sequence sequence = new Sequence();
            Searcher searcher = new Searcher();
            sequence = searcher.SearchLongestSequenceOfEqualNumbers(numbers, sequence);
            Assert.AreEqual(sequence.Length, 1);
            Assert.AreEqual(sequence.EqualNumber, 2);
        }

        [TestMethod]
        public void TestSearcherToCountThreNumbersAndValue()
        {
            List<int> numbers = new List<int>();
            numbers = new List<int> { 0, 0, 0 };
            Sequence sequence = new Sequence();
            Searcher searcher = new Searcher();
            sequence = searcher.SearchLongestSequenceOfEqualNumbers(numbers, sequence);
            Assert.AreEqual(sequence.Length, 3);
            Assert.AreEqual(sequence.EqualNumber, 0);
        }
    }
}
