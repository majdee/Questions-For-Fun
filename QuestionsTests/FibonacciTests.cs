using NUnit.Framework;
using Questions;
using System;

namespace Tests
{
    public class FibonacciTests
    {
        private Fibonacci _fibonacci;


        [SetUp]
        public void Setup()
        {
            _fibonacci = new Fibonacci();
        }

        [Test]
        public void Search_GivenNegativeNumber_ShouldThrowException()
        {
            // Arrange
            int n = -1;

            // Act
            Assert.Throws<ArgumentException>(() => _fibonacci.FindNth(n));
            Assert.Throws<ArgumentException>(() => _fibonacci.FindNthRecursive(n));
        }

        [Test]
        public void FindNth_GivenZero_ShouldReturn1()
        {
            // Arrange
            int n = 0;
            long expected = 1;

            // Act
            var result = _fibonacci.FindNth(n);
            Assert.AreEqual(result, expected);

            result = _fibonacci.FindNthRecursive(n);
            Assert.AreEqual(result, expected);

        }

        [Test]
        public void FindNth_GivenOne_ShouldReturn1()
        {
            // Arrange
            int n = 1;
            long expected = 1;

            // Act
            var result = _fibonacci.FindNth(n);
            Assert.AreEqual(result, expected);

            result = _fibonacci.FindNthRecursive(n);
            Assert.AreEqual(result, expected);

        }

        [Test]
        public void FindNth_GivenTen_ShouldReturn89()
        {
            // Arrange
            int n = 10;
            long expected = 89;

            // Act
            var result = _fibonacci.FindNth(n);
            Assert.AreEqual(result, expected);

            result = _fibonacci.FindNthRecursive(n);
            Assert.AreEqual(result, expected);

        }
    }
}