using System;
using System.Collections.Generic;

namespace Questions
{
    public class SearchInOrderedArray
    {
        public int Search(int[] array, int searchFor)
        {
            if(array == null || array.Length == 0)
                throw new ArgumentException("Invalid input", nameof(array));

            var lower = 0;
            var upper = array.Length -1;

            while (lower <= upper)
            {
                var index = (lower + upper) / 2;
                if (array[index] == searchFor)
                {
                    return array[index];
                }
                else if (array[index] < searchFor)
                {
                    lower = index+1;
                }
                else
                {
                    upper = index-1;
                }
            }

            throw new KeyNotFoundException();
        }

        public int SearchRecursive(int[] array, int searchFor)
        {
            if (array == null || array.Length == 0)
                throw new ArgumentException("Invalid input", nameof(array));

            return SearchRecursive(array, 0, array.Length - 1, searchFor);

        }
        private int SearchRecursive(int[] array,int lower,int upper, int searchFor)
        {
            if (lower <= upper)
            {
                var index = (lower + upper) / 2;
                if (array[index] == searchFor)
                {
                    return array[index];
                }
                else if (array[index] < searchFor)
                {
                    lower = index + 1;
                    return SearchRecursive(array, lower, upper, searchFor);
                }
                else
                {
                    upper = index - 1;
                    return SearchRecursive(array, lower, upper, searchFor);
                }
            }

            throw new KeyNotFoundException();
        }
    }
}
