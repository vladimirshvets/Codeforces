/* 
 * Task 758A
 * 
 * https://codeforces.com/problemset/problem/758/A
 */

// Read number of citizens and their balances.
int numberOfCitizens = int.Parse(Console.ReadLine());
int[] balances =
    Array.ConvertAll(Console.ReadLine().Split(' '), v => int.Parse(v));

// Find the richest citizen and calculate costs.
int maxBalance = balances.Max();
int expenses = 0;
Array.ForEach(balances, b => expenses += maxBalance - b);

// Write the result.
Console.WriteLine(expenses);
