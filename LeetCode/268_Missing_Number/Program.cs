using System;

namespace _268_Missing_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 0, 1 };
            Console.WriteLine(MissingNumber(nums));
        }

        public static int MissingNumber(int[] nums)
        {

            var Result = 0;
            var n = nums.Length;
            

            for(var i = 0; i<n ; i++)
            {
                var missingNuber = 0;

                for (var j = 0; j< n; j++)
                {
                    if(nums[j] == Result)
                    {
                        break;
                    }
                    if(nums[j] != Result)
                    {
                        missingNuber++;
                    }
                }

                if(missingNuber == n)
                {
                    return Result;
                }
                Result++;
            }

            return Result;
        }

    }
}
