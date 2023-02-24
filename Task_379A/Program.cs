/* 
 * Task 379A
 * 
 * The same approach as in previously solved 460A.
 * 
 * https://codeforces.com/problemset/problem/379/A
 */

string[] input = Console.ReadLine().Split(' ');
int numberOfCandles = int.Parse(input[0]);
int recyclingPeriod = int.Parse(input[1]);

Console.WriteLine(
    numberOfCandles + Math.Truncate(
        (decimal)(numberOfCandles - 1) / (recyclingPeriod - 1)));
