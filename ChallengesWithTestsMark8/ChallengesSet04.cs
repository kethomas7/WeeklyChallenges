using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int answer = 0;

            foreach (var numb in numbers)
            {

                if (numb % 2 == 0)
                {
                    answer += numb;
                }
                if (numb % 2 != 0)
                {
                    answer -= numb;
                }

            }
            return answer;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            int firstLength = str1.Length;
            int secondLength = str2.Length;
            int thirdLength = str3.Length;
            int forthLength = str4.Length;

            int[] lengths = new int[] { firstLength, secondLength, thirdLength, forthLength };


            return lengths.Min();
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            int[] numbers = new int[] { number1, number2, number3, number4 };

            return numbers.Min();

        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {

            if (sideLength1 + sideLength2 > sideLength3 && sideLength1 + sideLength3 > sideLength2 && sideLength2 + sideLength3 > sideLength1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool IsStringANumber(string input)
        {
            double number;
            if (double.TryParse(input, out number) )
            {            
                return true;   
            }
            else
            {
                return false;
            }
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            throw new NotImplementedException();
        }

        public double AverageEvens(int[] numbers)
        {
            List<double> numbersList = new List<double>();

            if( numbers == null|| !numbers.Any() )
                {
                    return 0;
                }


            foreach(var numb in numbers)
            {
       
                if (numb %2 == 0)
                {
                    numbersList.Add(numb);     
                }

            }

            if (!numbersList.Any())
            {
                return 0;
            }
            return numbersList.Average();


        }

        public int Factorial(int number)
        {
            throw new NotImplementedException();
        }
    }
}
