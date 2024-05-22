using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            return (vals.Contains(false) ? true : false);
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }
            else
            {
                return numbers.Where(x => x % 2 != 0).Sum() % 2 != 0 ? true : false;
            }
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            char[] charArray = password.ToCharArray();

            // charArray.ToList().ForEach(x => x.)
            for (var x = 0; x < charArray.Length - 1; x++)
            {
                bool isDigit = char.IsDigit(charArray[x]);
                bool isUpper = char.IsUpper(charArray[x]);
                bool isLower = char.IsLower(charArray[x]);
            }//goes through each 
            return true;
        }

        public char GetFirstLetterOfString(string val)
        {

            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            return val[val.Length - 1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            throw new NotImplementedException();
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length - 1] - nums[0];
        }
    
      
    

        public int[] GetOddsBelow100()
        {
            var odds = new int[0];
            int counter = 0;

         for (var x=1; x <99; x++ )
            {
                if (x % 2 != 0)
                {
                    odds[counter] = x;
                    counter++;
                }
            }
            return odds;
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {

            var uppercaseWords = words.Select(x => x.ToUpper().ToArray());
        }//ask about this
    }
}
