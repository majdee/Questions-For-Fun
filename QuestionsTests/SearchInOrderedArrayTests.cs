using NUnit.Framework;
using Questions;
using System;
using System.Collections.Generic;

namespace Tests
{
    public class SearchInOrderedArrayTests
    {
        private SearchInOrderedArray _searchInOrderArray;


        [SetUp]
        public void Setup()
        {
            _searchInOrderArray = new SearchInOrderedArray();
        }

        [Test]
        public void Search_GivenNullArray_ShouldThrowException()
        {
            // Arrange
            int[] inputArray = null;

            // Act
            Assert.Throws<ArgumentException>(() => _searchInOrderArray.Search(inputArray, 0));
            Assert.Throws<ArgumentException>(() => _searchInOrderArray.SearchRecursive(inputArray, 0));
        }

        [Test]
        public void Search_GivenNonEmptyArrayWithExistingNumber_ShouldFindTheNumber()
        {
            // Arrange
            int[] inputArray = new[] { 1, 2, 3, 4, 5 };
            var existingNumber = 4;

            // Act
            var result = _searchInOrderArray.Search(inputArray, existingNumber);
            Assert.AreEqual(result, existingNumber);

            result = _searchInOrderArray.SearchRecursive(inputArray, existingNumber);
            Assert.AreEqual(result, existingNumber);

        }

        [Test]
        public void Search_GivenNonEmptyArrayWithExistingNumberInLeftEdge_ShouldFindTheNumber()
        {
            // Arrange
            int[] inputArray = new[] { 1, 2, 3, 4, 5 };
            var existingNumber = 1;

            // Act
            var result = _searchInOrderArray.Search(inputArray, existingNumber);
            Assert.AreEqual(result, existingNumber);

            result = _searchInOrderArray.SearchRecursive(inputArray, existingNumber);
            Assert.AreEqual(result, existingNumber);

        }

        [Test]
        public void Search_GivenNonEmptyArrayWithExistingNumberInRightEdge_ShouldFindTheNumber()
        {
            // Arrange
            int[] inputArray = new[] { 1, 2, 3, 4, 5 };
            var existingNumber = 5;

            // Act
            var result = _searchInOrderArray.Search(inputArray, existingNumber);
            Assert.AreEqual(result, existingNumber);

            result = _searchInOrderArray.SearchRecursive(inputArray, existingNumber);
            Assert.AreEqual(result, existingNumber);

        }

        [Test]
        public void Search_GivenNonEmptyArrayWithoutNumber_ShouldThrowNotFoundException()
        {
            // Arrange
            int[] inputArray = new[] { 1, 2, 3, 4, 5 };
            var notExistingNumber = 6;

            // Act
            Assert.Throws<KeyNotFoundException>(() => _searchInOrderArray.Search(inputArray, notExistingNumber));
            Assert.Throws<KeyNotFoundException>(() => _searchInOrderArray.SearchRecursive(inputArray, notExistingNumber));

        }
    }
}