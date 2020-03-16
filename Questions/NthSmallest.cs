using System;
using System.Linq;

namespace Questions
{
    public class NthSmallest
    {
        public int FindNthSmallest_1(int[] numbers, int nth)
        {
            if (numbers == null || numbers.Length < nth)
                throw new Exception();

            Array.Sort(numbers);

            return numbers[nth-1];
        }

        public int FindNthSmallest_2(int[] numbers, int nth)
        {
            if (numbers == null || numbers.Length < nth)
                throw new Exception();

            var index = 0;
            var startIndex = 0;
            var endIndex = numbers.Length - 1;

            for (var i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > numbers[index])
                {
                    SwapNumbers(numbers, index, endIndex);
                    endIndex--;
                }
                else
                {
                    startIndex++;
                }
            }

            if (startIndex < nth)
            {
                return FindNthSmallest_2(numbers.Skip(startIndex).ToArray(), nth - startIndex);
            }

            return FindNthSmallest_2(numbers.Take(startIndex).ToArray(), nth);

        }

        private void SwapNumbers(int[] numbers, int i, int index)
        {
            var temp = numbers[i];
            numbers[i] = numbers[index];
            numbers[index] = temp;
        }

        public int FindMin(int[] numbers)
        {
            if (numbers == null || numbers.Length < 1)
                throw new Exception();

            var min = numbers[0];

            foreach (var number in numbers)
            {
                if (number < min)
                {
                    min = number;
                }
            }

            return min;
        }

        public int FindSecondMin(int[] numbers)
        {
            if (numbers == null || numbers.Length < 2)
                throw new Exception();

            var firstMin = numbers[0];
            var secondMin = numbers[1];

            foreach (var number in numbers)
            {
                if (number < firstMin)
                {
                    secondMin = firstMin;
                    firstMin = number;
                }
                else if (number < secondMin)
                {
                    secondMin = number;
                }
            }

            return secondMin;
        }
    }
}
