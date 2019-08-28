using System;

namespace Questions.DataStructure
{
    public class Node 
    {
        public Node(int value)
        {
            Value = value;
            Parent = null;
        }

        public Node(int value, Node parent)
        {
            Value = value;
            Parent = parent;
        }

        public Node Parent { get; set; }

        public int Value { get; set; }

        public Node Left { get; set; }

        public Node Right { get; set; }

        public bool IsLeaf => Left == null && Right == null;
        public bool IsRoot => Parent == null;
    }
}