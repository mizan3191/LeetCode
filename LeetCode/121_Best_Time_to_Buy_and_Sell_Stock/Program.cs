using System;

namespace _121_Best_Time_to_Buy_and_Sell_Stock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] prices = new int[] { 7, 6, 4, 3, 1 };
            Console.WriteLine(MaxProfit(prices));
        }

        public static int MaxProfit(int[] prices)
        {
            var BestPriceToBuy = prices[0];
            var MaxProfit = 0;

            if(prices.Length > 1)
            {
                for (var i = 1; i < prices.Length; i++)
                {
                    MaxProfit = Math.Max(MaxProfit, prices[i] - BestPriceToBuy);
                    BestPriceToBuy = Math.Min(BestPriceToBuy, prices[i]);
                }
            }

            return MaxProfit;
        }
    }
}