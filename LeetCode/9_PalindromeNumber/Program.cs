using System;

namespace _9_PalindromeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var x = 1215;

            int newNumber = 0, remain = 0, divide = 0;

            while (x > 0)
            {
                
                remain = x % 10;
                x = x / 10;

                newNumber = newNumber * 10 + remain;
            }

            Console.WriteLine(newNumber);
        }

        public static bool isPalindrome(int x)
        {
            var copy = x;

            long newNumber = 0, remain = 0;

            while (x>0)
            {
                remain = x / 10;
                x = x % 10;
                newNumber = newNumber * 10 + remain;
            }

            if(copy == newNumber)
            {
                return true;
            }

            return false;
        }
    }
}