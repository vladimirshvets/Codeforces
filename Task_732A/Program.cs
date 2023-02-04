/* 
 * Task 732A
 * 
 * https://codeforces.com/problemset/problem/732/A
 */

// Read the cost of shovel and the coin denomination.
string input = Console.ReadLine();
string[] separatedInput = input.Split(' ');
int shovelCost = int.Parse(separatedInput[0]);
int coinDenomination = int.Parse(separatedInput[1]);

// Find the minimum number of shovels to buy (it's non greater than 10).
int costLastDigit = shovelCost % 10;
int numberOfShovels = 0;
for (int i = 1; i <= 10; i++)
{
    int summLastDigit = costLastDigit * i % 10;
    if (summLastDigit == coinDenomination || summLastDigit == 0)
    {
        numberOfShovels = i;
        break;
    }
}

// Write the result.
Console.WriteLine(numberOfShovels);
