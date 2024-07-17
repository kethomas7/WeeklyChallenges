using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {

            do
            {
                startNumber++;
            }

            while (startNumber % n != 0);

            return startNumber;


        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            throw new NotImplementedException();
        }

        public bool IsAscendingOrder(int[] numbers)
        {

            throw new NotImplementedException();
            //int[] sorted = new int[0];

            //Array.Sort(numbers);

            // return numbers.SequenceEqual()
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            int result = 0;

            if (numbers == null)
            {
                return 0;
            }
            for (var x = 0; x < numbers.Length - 1; x++)
            {

                if (numbers[x] % 2 == 0)
                {
                    result += numbers[x + 1];
                }
            }
            return result;
        }

        public string TurnWordsIntoSentence(string[] words)
        {

            if (words == null ||words.Any() )
            {
                return "";
            }
            else 
            {
                string sentence = String.Join(" ", words.Where(word => !string.IsNullOrWhiteSpace(word)));


                return $"{sentence}.";
            }
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            throw new NotImplementedException();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            throw new NotImplementedException();
        }
    }
}
