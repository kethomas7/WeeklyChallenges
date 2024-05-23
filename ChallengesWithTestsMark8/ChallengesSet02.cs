using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return Char.IsLetter(c);
        }

        public bool CountOfElementsIsEven(string[] vals)
        {

            if (vals.Length % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool IsNumberEven(int number)
        {
            return number % 2 == 0 ? true : false;
        }

        public bool IsNumberOdd(int num)
        {
            return num % 2 != 0 ? true : false;
        }


        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {

            if (numbers == null || numbers.Any() == false)
            {
                    return 0;
 
            }
            return numbers.Max() + numbers.Min();
       
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            if (str1.Length < str2.Length)
            {
                return str1.Length;

            }
            else
            {
                return str2.Length;
            }

        }

        public int Sum(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }

            var total = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                total += numbers[i];
            }
            return total;
        }

        public int SumEvens(int[] numbers)
        {

            var total = 0;
            if (numbers == null)
            {
                return 0;
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    total += numbers[i];
                }

            }
            return total;

        }

        public bool IsSumOdd(List<int> numbers)
        {

            if (numbers == null)
            {
                return false;
            }

            int oddsTotal = Sum(numbers.ToArray());

            return oddsTotal % 2 != 0 ? true : false;

        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            if (number <=0)
                {
                return 0;
            }

            else
            {
                return number / 2;
            }
           
            

          
        }
    }
}
