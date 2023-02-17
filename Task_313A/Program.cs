/* 
 * Task 313A
 * 
 * https://codeforces.com/problemset/problem/313/A
 */

// Read the account balance.
int balance = int.Parse(Console.ReadLine());

// Produce possible options.
int[] options = new int[]
{
    balance,
    balance / 10,
    balance / 100 * 10 + balance % 10
};

// Write the result.
Console.WriteLine(options.Max());
