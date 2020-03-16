using NUnit.Framework;
using Questions;
using System;

namespace Tests
{
    public class StackTests
    {
        [Test]
        public void Stack_GivenStackOfSizeTwo_ShouldWorksAsFirstInLastOut()
        {
            // Arrange
            var stack = new Stack(2);

            // Act
            stack.Push(1);
            stack.Push(2);
            Assert.AreEqual(2,stack.Peek());
            Assert.AreEqual(2,stack.Pop());
            Assert.AreEqual(1,stack.Pop());
            
        }

        [Test]
        public void Stack_GivenStackOfSizeOneAndTryToAddTwoNumber_ShouldThrowException()
        {
            // Arrange
            var stack = new Stack(1);

            // Act
            stack.Push(1);
            Assert.Throws<Exception>(() => stack.Push(1));

        }

        [Test]
        public void Stack_GivenStackOfSizeOneAndTryToPeekFromEmpty_ShouldThrowException()
        {
            // Arrange
            var stack = new Stack(1);

            // Act
            Assert.Throws<Exception>(() => stack.Peek());

        }

        [Test]
        public void Stack_GivenStackOfSizeOneAndTryToPopFromEmpty_ShouldThrowException()
        {
            // Arrange
            var stack = new Stack(1);

            // Act
            Assert.Throws<Exception>(() => stack.Pop());

        }


    }
}