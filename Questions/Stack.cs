using System;

namespace Questions
{
    public interface IStack
    {
        int Peek();
        int Pop();
        void Push(int input);
        int Length { get; }
    }
    public class Stack : IStack
    {
        private readonly int _capacity;
        private readonly int[] _elements;
        private int _currentIndex;

        public Stack(int capacity)
        {
            _capacity = capacity;
            _elements = new int[capacity];
            _currentIndex = -1;
        }

        public int Peek()
        {
            if (_currentIndex == -1)
                throw new Exception("Empty stack");

            return _elements[_currentIndex];
        }

        public int Pop()
        {
            if (_currentIndex == -1)
                throw new Exception("Empty stack");

            return _elements[_currentIndex--];

        }

        public void Push(int input)
        {
            if (_currentIndex + 1 >= _capacity)
                throw new Exception("Stack is full");

            _elements[++_currentIndex] = input;
        }

        public int Length => _currentIndex + 1;
    }
}
