using System;

namespace _122_Best_Time_to_Buy_and_Sell_Stock_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] prices = new int[] { 5, 2, 6,1, 4,7, 3, 6 };
            Console.WriteLine(MaxProfit(prices));
        }

        public static int MaxProfit(int[] prices)
        {
           
            var MaxProfit = 0;

            if (prices.Length > 1)
            {
                 for(var i = 1; i < prices.Length; i++)
                {
                    if(prices[i] > prices[i - 1])
                    {
                        MaxProfit += (prices[i] - prices[i-1]) ;
                    }
                }
            }

            return MaxProfit;
        }

    }
}
