using System;

namespace Questions
{
    public class Fibonacci
    {
        public long FindNth(int n)
        {
            if (n < 0)
                throw new ArgumentException();

            if (n < 2)
                return 1;

            var current = 1;
            var prev = 1;
            var counter = 1;

            while (counter < n)
            {
                var temp = prev;
                prev = current;
                current = prev + temp;
                counter++;
            }

            return current;

        }

        public long FindNthRecursive(int n)
        {
            if (n < 0)
                throw new ArgumentException();

            if (n < 2)
                return 1;

            return FindNthRecursive(n - 1) + FindNthRecursive(n - 2);
        }
    }
}
