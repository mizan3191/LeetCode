using System;

namespace _344_Reverse_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] s = { 'a', 'b', 'c', 'd', 'e', 'f' };
            ReverseString(s);
        }
        public static void ReverseString(char[] s)
        {
            for(int i = s.Length-1, j=0 ; i >=s.Length/2 ; i--, j++)
            {
                var x = s[i];
                s[i] = s[j];
                s[j] = x;
            }
        }
    }
}