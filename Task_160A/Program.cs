/* 
 * Task 160A
 * 
 * https://codeforces.com/problemset/problem/160/A 
 */

// Read the number of coins and their denominations.
int numberOfCoins = int.Parse(Console.ReadLine());
string input = Console.ReadLine();
string[] separatedInput = input.Split(' ');
int[] coinDenominations = Array.ConvertAll(separatedInput, v => int.Parse(v));

// Sort the denominations.
Array.Sort(coinDenominations);

// Calculate the minimum summ to meet conditions.
int summOfCoins = coinDenominations.Sum();
int minSumm = summOfCoins / 2 + 1;

// Take the coins one by one from the largest one.
int minNumberOfCoinsToTake = 0;
int actualSummOfCoins = 0;
for (int i = numberOfCoins - 1; i >= 0; i--)
{
    minNumberOfCoinsToTake++;
    actualSummOfCoins += coinDenominations[i];
    if (actualSummOfCoins >= minSumm)
    {
        break;
    }
}

// Write the result.
Console.WriteLine(minNumberOfCoinsToTake);
