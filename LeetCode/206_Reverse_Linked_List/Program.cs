using System;

namespace _206_Reverse_Linked_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] list = new int[] {1,2,3,4,5};
            ReverseList(list);
            Console.WriteLine("Hello World!");
        }
        public static int[] ReverseList(int[] head)
        {
            var n = head.Length;

            for(int i=0, j=n-1; i<n/2; i++,j--)
            {
               var temp = head[i];
                head[i] = head[j];
                head[j] = temp;
            }
            return head;
        }
    }
}
