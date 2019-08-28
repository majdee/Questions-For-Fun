using NUnit.Framework;
using Questions;
using Questions.DataStructure;

namespace QuestionsTests
{
    public class TraversalTreeTests
    {
        private BinaryTree _oneLevelTree = new BinaryTree(new[] { 10 });
        private BinaryTree _twoLevelTree = new BinaryTree(new[] { 10, 11, 9 });
        private BinaryTree _threeLevelTree = new BinaryTree(new[] { 10, 15, 5, 4, 6, 16, 14 });

        private TraversalTree _traversalTree = new TraversalTree();

        [Test]
        public void InOrder_GivenOneLevel_GetOrder()
        {
            // Arrange 
            var expected = new[] { 10 };

            // Act
            var result = _traversalTree.InOrder(_oneLevelTree);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void PreOrder_GivenOneLevel_GetOrder()
        {
            // Arrange 
            var expected = new[] { 10 };

            // Act
            var result = _traversalTree.PreOrder(_oneLevelTree);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void PostOrder_GivenOneLevel_GetOrder()
        {
            // Arrange 
            var expected = new[] { 10 };

            // Act
            var result = _traversalTree.PostOrder(_oneLevelTree);

            // Assert
            Assert.AreEqual(expected, result);
        }


        [Test]
        public void InOrder_GivenTwoLevel_GetOrder()
        {
            // Arrange 
            var expected = new[] { 9, 10, 11 };

            // Act
            var result = _traversalTree.InOrder(_twoLevelTree);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void PreOrder_GivenTwoLevel_GetOrder()
        {
            // Arrange 
            var expected = new[] { 10, 9, 11 };

            // Act
            var result = _traversalTree.PreOrder(_twoLevelTree);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void PostOrder_GivenTwoLevel_GetOrder()
        {
            // Arrange 
            var expected = new[] { 9, 11, 10 };

            // Act
            var result = _traversalTree.PostOrder(_twoLevelTree);

            // Assert
            Assert.AreEqual(expected, result);
        }


        [Test]
        public void InOrder_GivenThreeLevel_GetOrder()
        {
            // Arrange 
            var expected = new[] { 4, 5, 6, 10, 14, 15, 16 };

            // Act
            var result = _traversalTree.InOrder(_threeLevelTree);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void PreOrder_GivenThreeLevel_GetOrder()
        {
            // Arrange 
            var expected = new[] { 10, 5, 4, 6, 15, 14, 16 };

            // Act
            var result = _traversalTree.PreOrder(_threeLevelTree);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void PostOrder_GivenThreeLevel_GetOrder()
        {
            // Arrange 
            var expected = new[] { 4, 6, 5, 14, 16, 15, 10 };

            // Act
            var result = _traversalTree.PostOrder(_threeLevelTree);

            // Assert
            Assert.AreEqual(expected, result);
        }

    }
}
