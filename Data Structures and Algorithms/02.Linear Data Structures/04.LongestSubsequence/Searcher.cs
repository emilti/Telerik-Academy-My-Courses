namespace LinearDataStructures
{
    using System.Collections.Generic;

    public class Searcher
    {
        public Sequence SearchLongestSequenceOfEqualNumbers(List<int> numbers,Sequence sequence)
        {
            int length = 1;
            int number = numbers[0];
            sequence.EqualNumber = numbers[0];
            sequence.Length = 1;
            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    length++;
                }

                if (numbers[i] != numbers[i - 1] && length > sequence.Length)
                {
                    sequence.Length = length;
                    sequence.EqualNumber = numbers[i - 1];
                    length = 1;
                }

                if (length >= sequence.Length &&
                    numbers[i] == numbers[i - 1] &&
                    i == numbers.Count - 1)
                {
                    sequence.EqualNumber = numbers[i];
                    sequence.Length = length;
                    length = 1;
                }
            }

            return sequence;
        }

    }
}
