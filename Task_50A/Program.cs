/* 
 * Task 50A
 * 
 * https://codeforces.com/problemset/problem/50/A 
 */

// Read the board sizes - integer values in range [1..16].
string input = Console.ReadLine();
string[] inputSeparatedValues = input.Split(' ');
int M = int.Parse(inputSeparatedValues[0]);
int N = int.Parse(inputSeparatedValues[1]);

// Dominoes have size 2x1.
// Thus, the board is fully covered if a number of cells is even.
int numberOfDominoes = M * N / 2;

// Write the result.
Console.WriteLine(numberOfDominoes);