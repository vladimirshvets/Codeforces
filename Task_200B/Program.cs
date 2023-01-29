/* 
 * Task 200B
 * 
 * https://codeforces.com/problemset/problem/200/B
 */

// Read the number of drinks and their percentages.
int numberOfDrinks = int.Parse(Console.ReadLine());
string input = Console.ReadLine();
string[] separatedInput = input.Split(' ');
int[] percentages = Array.ConvertAll(separatedInput, v => int.Parse(v));

// Find the average percentage.
int percentageSumm = percentages.Sum();
double averagePercentage = (double)percentageSumm / numberOfDrinks;

// Write the result.
Console.WriteLine(averagePercentage);