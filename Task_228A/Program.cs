/* 
 * Task 228A
 * 
 * https://codeforces.com/problemset/problem/228/A
 */

// Read the horseshoe colors.
string input = Console.ReadLine();
string[] separatedInput = input.Split(' ');

// Calculate the number of unique colors.
int numberOfUniqueHorseshoes = separatedInput.Distinct().Count();

// Write the result.
Console.WriteLine(4 - numberOfUniqueHorseshoes);
