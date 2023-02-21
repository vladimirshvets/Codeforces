/* 
 * Task 460A
 * 
 * https://codeforces.com/problemset/problem/460/A
 */

string[] input = Console.ReadLine().Split(' ');
int numberOfPairs = int.Parse(input[0]);
int shoppingPeriod = int.Parse(input[1]);

int lastDay = 0;
int lastShoppingDay = 0;
while (numberOfPairs > 0)
{
    lastDay += numberOfPairs;
    numberOfPairs = (lastDay - lastShoppingDay) / shoppingPeriod;
    lastShoppingDay += numberOfPairs * shoppingPeriod;
}

Console.WriteLine(lastDay);
