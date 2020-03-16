using NUnit.Framework;
using Questions;
using System;
using System.Linq;

namespace QuestionsTests
{
    public class NthSmallestTests
    {
        readonly NthSmallest _nthSmallest = new NthSmallest();

        [Test]
        public void FindMin_GivenNumbers_ShouldReturnTheMin()
        {
            // Arrange
            var numbers = new int[] {10, 5, 15, 1, 20};

            // Act
            var actualMin = _nthSmallest.FindMin(numbers);

            // Assert
            var expectedMin = numbers.Min();
            Assert.AreEqual(expectedMin,actualMin);
        }

        [Test]
        public void FindSecondMin_GivenNumbers_ShouldReturnTheSecondMin()
        {
            // Arrange
            var numbers = new int[] { 10, 5, 15, 1, 20 };

            // Act
            var actualMin = _nthSmallest.FindSecondMin(numbers);

            // Assert
            Array.Sort(numbers);

            var expectedSecondMin =  numbers[1];
            Assert.AreEqual(expectedSecondMin, actualMin);
        }

        [Test]
        public void FindNthSmallest_1_GivenNumbers_ShouldReturnTheThirdMin()
        {
            // Arrange
            var numbers = new int[] { 10, 5, 15, 1, 20 };

            // Act
            var actualMin = _nthSmallest.FindNthSmallest_1(numbers,3);

            // Assert
            Array.Sort(numbers);

            var expectedSecondMin = numbers[2];
            Assert.AreEqual(expectedSecondMin, actualMin);
        }

        [Test]
        public void FindNthSmallest_2_GivenNumbers_ShouldReturnTheThirdMin()
        {
            // Arrange
            var numbers = new int[] { 10, 5, 15, 1, 20 };

            // Act
            var actualMin = _nthSmallest.FindNthSmallest_2(numbers, 3);

            // Assert
            Array.Sort(numbers);

            var expectedSecondMin = numbers[2];
            Assert.AreEqual(expectedSecondMin, actualMin);
        }


    }
}
