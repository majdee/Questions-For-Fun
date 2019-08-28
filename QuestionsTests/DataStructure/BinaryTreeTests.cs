using NUnit.Framework;
using Questions.DataStructure;

namespace Tests
{
    public class BinaryTreeTests
    {
        
        [Test]
        public void Add_GivenTreeWithRootAndBiggerNumber_ShouldBeLocatedAsRight()
        {
            // Arrange
            var binaryTree = new BinaryTree(new Node(100));
            var numberToAdd = 111;

            // Act
           binaryTree.Add(numberToAdd);

            // Assert
            Assert.AreEqual(numberToAdd, binaryTree.Root.Right.Value);
        }

        [Test]
        public void Add_GivenTree_ShouldAddTheNumber()
        {
            // Arrange
            /*
             *              100
             *          90      110
             *              95
             */
            var binaryTree = new BinaryTree(new Node(100));
            binaryTree.Add(90);
            binaryTree.Add(110);
            binaryTree.Add(95);


            // Assert
            Assert.AreEqual(90, binaryTree.Root.Left.Value);
            Assert.AreEqual(110, binaryTree.Root.Right.Value);
            Assert.AreEqual(95, binaryTree.Root.Left.Right.Value);
        }

        [Test]
        public void Delete_GivenNotRoot_ShouldDeleteAndReplace()
        {
            // Arrange
            /*
             *              100                 100
             *          90      110    ->    95     110
             *       80    95             80    
             *          85                   85
             */
            var binaryTree = new BinaryTree(new Node(100));
            binaryTree.Add(90);
            binaryTree.Add(110);
            binaryTree.Add(80);
            binaryTree.Add(95);
            binaryTree.Add(85);

            // Act 
            binaryTree.Delete(90);

            // Assert
            Assert.AreEqual(100, binaryTree.Root.Value);
            Assert.AreEqual(95, binaryTree.Root.Left.Value);
            Assert.AreEqual(110, binaryTree.Root.Right.Value);
            Assert.AreEqual(80, binaryTree.Root.Left.Left.Value);
            Assert.AreEqual(85, binaryTree.Root.Left.Left.Right.Value);
        }

        [Test]
        public void Delete_GivenRootWithNoSmallerValue_ShouldDeleteTheRoot()
        {
            // Arrange
            /*
             *              100                 110
             *                  110    ->         
             */
            var binaryTree = new BinaryTree(new Node(100));
            binaryTree.Add(110);


            // Act 
            binaryTree.Delete(100);

            // Assert
            Assert.AreEqual(110, binaryTree.Root.Value);
            Assert.IsTrue(binaryTree.Root.IsLeaf);
        }

        [Test]
        public void Delete_GivenRootWithSmallerValues_ShouldDeleteRootAndReplace()
        {
            // Arrange
            /*
             *              100                   110    
             *          90      110    ->     90       
             *       80    95              80    95       
             *          85                    85          
             */
            var binaryTree = new BinaryTree(new Node(100));
            binaryTree.Add(90);
            binaryTree.Add(110);
            binaryTree.Add(80);
            binaryTree.Add(95);
            binaryTree.Add(85);

            // Act 
            binaryTree.Delete(100);

            // Assert
            Assert.AreEqual(110, binaryTree.Root.Value);
            Assert.IsNull(binaryTree.Root.Right);
            Assert.AreEqual(90, binaryTree.Root.Left.Value);
            Assert.AreEqual(95, binaryTree.Root.Left.Right.Value);
            Assert.AreEqual(80, binaryTree.Root.Left.Left.Value);
            Assert.AreEqual(85, binaryTree.Root.Left.Left.Right.Value);
        }


    }
}