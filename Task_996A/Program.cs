/* 
 * Task 996A
 * 
 * https://codeforces.com/problemset/problem/996/A
 */

// Read the total amount of money.
int totalAmount = int.Parse(Console.ReadLine());

// Array of available banknotes sorted in descending order.
var availableBanknotes = new int[5] { 100, 20, 10, 5, 1 };

// Calculate the number of banknotes to withdraw.
int numberOfBanknotes = 0;
for (int i = 0; i < availableBanknotes.Length; i++)
{
    numberOfBanknotes += totalAmount / availableBanknotes[i];
    totalAmount %= availableBanknotes[i];
}

// Write the result.
Console.WriteLine(numberOfBanknotes);
