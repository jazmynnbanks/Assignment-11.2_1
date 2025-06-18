//1. Listen and ask question
//ou are given an array prices where prices[i] is the price of a given stock on the ith day.
//You want to maximize your profit by choosing a single day to buy one stock and choosing a different day in the future to sell that stock.

//Return the maximum profit you can achieve from this transaction. If you cannot achieve any profit, return 0.

//Can you buy and sell the stock on the same day?
//What if the prices are in descending order?

//2. Generate Examples
// Example 1:[7,1,5,3,6,4] Output: 5
// Example 2:[7,6,4,3,1] Output: 0
// Example 3:[1,2,3,4,5] Output: 4

//3. Pseudocode
//

static int SellorBuyStock (int[] prices)
{
    int buy = 0, sale = 1;
    int profit, maxProfit = 0;

    while (sale < prices.Length)
    {
        if (prices[buy] < prices[sale])
        {
            profit = prices[sale] - prices[buy];
            maxProfit = Math.Max(maxProfit, profit);
        }
        else
        {
            buy = sale;
        }
        sale++;
    }
    return maxProfit;
}

int[] prices = { 6, 2, 3, 9, 1, 4, 8 };
int profit = SellorBuyStock(prices);
Console.WriteLine($"Maximum profit: {profit}");
Console.ReadKey();