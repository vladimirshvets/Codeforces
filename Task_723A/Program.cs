/* 
 * Task 723A
 * 
 * https://codeforces.com/problemset/problem/723/A
 */

// Read the coordinates.
string input = Console.ReadLine();
string[] separatedInput = input.Split(' ');
int[] coordinates = Array.ConvertAll(separatedInput, c => int.Parse(c));

// Sort the coordinates to determine the maximum and minimum.
Array.Sort<int>(coordinates);

// Write the result.
Console.WriteLine(coordinates[2] - coordinates[0]);
