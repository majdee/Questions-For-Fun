using Questions.DataStructure;
using System.Collections.Generic;

namespace Questions
{
    public class TraversalTree
    {
        // Left -> Root -> Right
        public int[] InOrder(BinaryTree binaryTree)
        {
            var order = new List<int>();

            InOrder(binaryTree.Root, order);

            return order.ToArray();
        }

        private void InOrder(Node node, List<int> currentOrder)
        {
            if (node == null)
                return;

            if (node.Left != null)
            {
                InOrder(node.Left, currentOrder);
            }

            currentOrder.Add(node.Value);

            if (node.Right != null)
            {
                InOrder(node.Right, currentOrder);
            }
        }

        // Root -> Left -> Right
        public int[] PreOrder(BinaryTree binaryTree)
        {
            var order = new List<int>();

            PreOrder(binaryTree.Root, order);

            return order.ToArray();
        }

        private void PreOrder(Node node, List<int> currentOrder)
        {
            if (node == null)
                return;

            currentOrder.Add(node.Value);

            if (node.Left != null)
            {
                PreOrder(node.Left, currentOrder);
            }

            if (node.Right != null)
            {
                PreOrder(node.Right, currentOrder);
            }
        }

        // Left -> Right -> Root
        public int[] PostOrder(BinaryTree binaryTree)
        {
            var order = new List<int>();

            PostOrder(binaryTree.Root, order);

            return order.ToArray();
        }

        private void PostOrder(Node node, List<int> currentOrder)
        {
            if (node == null)
                return;

            if (node.Left != null)
            {
                PostOrder(node.Left, currentOrder);
            }

            if (node.Right != null)
            {
                PostOrder(node.Right, currentOrder);
            }

            currentOrder.Add(node.Value);
        }

    }
}
