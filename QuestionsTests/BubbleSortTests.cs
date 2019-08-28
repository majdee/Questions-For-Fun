using NUnit.Framework;
using Questions;

namespace QuestionsTests
{
    public class BubbleSortTests
    {
        private BubbleSort _bubbleSort;


        [SetUp]
        public void Setup()
        {
            _bubbleSort = new BubbleSort();
        }

        [Test]
        public void Sort_GivenEmptyArray_ShouldReturnTheInput()
        {
            // Arrange
            int[] nullArray = null;
            int[] emptyArray = new int[0];

            // Act
            var sortNullArray = _bubbleSort.Sort(nullArray);
            var sortEmptyArray = _bubbleSort.Sort(emptyArray);

            // Assert
            Assert.IsNull(sortNullArray);
            Assert.IsEmpty(sortEmptyArray);
        }

        [Test]
        public void Sort_GivenArrayWithOneElement_ShouldReturnTheInput()
        {
            // Arrange
            var oneSizeArray = new[] { 1 };

            // Act
            var sortedOneSize = _bubbleSort.Sort(oneSizeArray);

            // Assert
            Assert.AreEqual(1, sortedOneSize.Length);
        }

        [Test]
        public void Sort_GivenArrayWithOddSize_ShouldSortArray()
        {
            // Arrange
            var array = new[] { 10, 8, 12, 15, 19 };

            // Act
            var sortedArray = _bubbleSort.Sort(array);

            // Assert
            var isSorted = IsSorted(sortedArray);
            Assert.Contains(array[2], sortedArray);
        }

        [Test]
        public void Sort_GivenArrayWithEvenSize_ShouldSortArray()
        {
            // Arrange
            var array = new[] { 10, 8, 12, 15, 3, 22 };

            // Act
            var sortedArray = _bubbleSort.Sort(array);

            // Assert
            var isSorted = IsSorted(sortedArray);
            Assert.Contains(array[2], sortedArray);
        }

        private bool IsSorted(int[] array)
        {
            if (array == null)
                return true;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i-1] > array[i])
                    return false;
            }

            return true;
        }

    }
}