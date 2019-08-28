using System;

namespace Questions.DataStructure
{
    public class BinaryTree
    {
        public Node Root { get; private set; }

        public BinaryTree(Node root)
        {
            Root = root;
        }

        public BinaryTree(int[] array)
        {
            if(array == null || array.Length < 1)
                throw new ArgumentNullException();

            Root = new Node(array[0]);

            for (int i = 1; i < array.Length; i++)
            {
                Add(array[i]);
            }
        }

        public void Add(int newValue)
        {
            var currentNode = Root;

            while (!currentNode.IsLeaf)
            {
                var next = newValue < currentNode.Value
                                ? currentNode.Left
                                : currentNode.Right;
                if (next == null)
                {
                    break;
                }

                currentNode = next;
            }

            if (newValue < currentNode.Value)
                currentNode.Left = new Node(newValue, currentNode);
            else
                currentNode.Right = new Node(newValue, currentNode);
        }


        public void Delete(int value)
        {
            var node = Find(value);
            if (node == null)
                return;

            var smallestGreaterThan = FindSmallestGreater(node);

            Node replaceNode = smallestGreaterThan ?? node.Left;
            replaceNode.Left = node.Left;

            if (node.IsRoot)
            {
                Root = replaceNode;
            }
            else if (node.Parent.Value > node.Value)
            {
                node.Parent.Left = replaceNode;
            }
            else
            {
                node.Parent.Right = replaceNode;
            }

            node = null;
        }

        private Node FindSmallestGreater(Node node)
        {
            if (node?.Right == null)
                return null;

            var currentNode = node.Right;
            while (currentNode.Left != null)
            {
                currentNode = currentNode.Left;
            }

            return currentNode;
        }

        public Node Find(int value)
        {
            var currentNode = Root;

            while (currentNode != null)
            {
                if (currentNode.Value == value)
                    return currentNode;

                currentNode = value < currentNode.Value
                                ? currentNode.Left
                                : currentNode.Right;
            }

            return null;
        }
    }
}
