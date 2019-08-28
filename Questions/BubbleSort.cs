namespace Questions
{
    public class BubbleSort
    {
        public int[] Sort(int[] originalArray)
        {
            var array = (int[])originalArray?.Clone();

            if (array == null || array.Length < 2)
                return array;

            for (var groupSize = 1; groupSize < array.Length; groupSize *= 2)
            {
                for (var i = 0; i < array.Length; i += 2 * groupSize)
                {
                    SortSortedArray(array, i, groupSize);
                }
            }

            return array;
        }

        private void SortSortedArray(int[] array, int startAt, int groupSize)
        {
            var firstPartIndex = startAt;
            var secondPartIndex = startAt + groupSize;

            while (firstPartIndex < groupSize + startAt && secondPartIndex < 2 * groupSize + startAt
                   && firstPartIndex < array.Length && secondPartIndex <array.Length)
            {
                if (array[firstPartIndex] > array[secondPartIndex])
                {
                    var temp = array[firstPartIndex];
                    array[firstPartIndex] = array[secondPartIndex];
                    array[secondPartIndex] = temp;
                    secondPartIndex++;
                }
                else
                {
                    firstPartIndex++;
                }
            }

        }
    }
}
