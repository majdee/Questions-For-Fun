using NUnit.Framework;
using Questions.DataStructure;

namespace Tests
{
    public class NodeTests
    {

        [Test]
        public void Node_GivenValueWithParent()
        {
            // Arrange
            var parentNode = new Node(10);
            var nodeValue = 5;


            // Act
            var node = new Node(5, parentNode);

            // Assert
            Assert.AreEqual(nodeValue, node.Value);
            Assert.AreEqual(parentNode.Value, node.Parent.Value);
        }

        [Test]
        public void Node_GivenValueWithNoParent()
        {
            // Arrange
            var nodeValue = 5;

            // Act
            var node = new Node(5);

            // Assert
            Assert.AreEqual(nodeValue, node.Value);
            Assert.IsNull(node.Parent);
        }

        [Test]
        public void IsLeaf_GivenOneLeafAndNotLeaf_ShouldIdentifyLeaf()
        {
            // Arrange
            var leafNode = new Node(1);
            var notLeafNode = new Node(10)
            {
                Left = new Node(2)
            };

            // Assert
            Assert.IsTrue(leafNode.IsLeaf);
            Assert.IsFalse(notLeafNode.IsLeaf);
        }

        [Test]
        public void IsRoot_GivenOneRootAndNotRoot_ShouldIdentifyLeaf()
        {
            // Arrange
            var rootNode = new Node(1);
            var notRootNode = new Node(10, rootNode);

            // Assert
            Assert.IsTrue(rootNode.IsRoot);
            Assert.IsFalse(notRootNode.IsRoot);
        }
    }
}