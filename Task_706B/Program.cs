/* 
 * Task 706B
 * 
 * https://codeforces.com/problemset/problem/706/B
 */

// Read the number of shops and related prices, sort the prices.
int numberOfShops = int.Parse(Console.ReadLine());
int[] prices =
    Array.ConvertAll(Console.ReadLine().Split(' '), v => int.Parse(v));
Array.Sort(prices);

// Read the balance and search for alcohol available for purchase.
int numberOfDays = int.Parse(Console.ReadLine());
for (int i = 0; i < numberOfDays; i++)
{
    int balance = int.Parse(Console.ReadLine());
    int startIndex = 0;
    int finishIndex = numberOfShops - 1;
    while (startIndex <= finishIndex)
    {
        int index = (startIndex + finishIndex) / 2;
        if (balance >= prices[index])
        {
            startIndex = index + 1;
        }
        else
        {
            finishIndex = index - 1;
        }
    }

    // Write the result.
    Console.WriteLine(finishIndex + 1);
}
