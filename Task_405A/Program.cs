/* 
 * Task 405A
 * 
 * https://codeforces.com/problemset/problem/405/A
 */

// Read the number of columns and column heights.
int numberOfColumns = int.Parse(Console.ReadLine());
string input = Console.ReadLine();
string[] separatedInput = input.Split(' ');
int[] columnHeights = Array.ConvertAll(separatedInput, v => int.Parse(v));

// Sort the heights.
Array.Sort(columnHeights);

// Write the result.
Array.ForEach(columnHeights, h => Console.Write($"{h} "));
