using System;

namespace _21_Merge_Two_Sorted_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list1 = new int[] { 1, 2, 4 };
            var list2 = new int[] { 1, 3, 4 };

            Console.WriteLine(MergeTwoLists(list1, list2));
        }
        public static int[] MergeTwoLists(int[] list1, int[] list2)
        {
            var newArray = new int[list1.Length + list2.Length];

            return list1;
        }
    }
}
