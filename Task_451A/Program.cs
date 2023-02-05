/* 
 * Task 451A
 * 
 * https://codeforces.com/problemset/problem/451/A
 */

// Read the number of rows and columns.
string input = Console.ReadLine();
string[] separatedInput = input.Split(' ');
int numberOfRows = int.Parse(separatedInput[0]);
int numberOfColumns = int.Parse(separatedInput[1]);

// Find the number of turns to finish the game.
int numberOfTurns = Math.Min(numberOfRows, numberOfColumns);

// Write the result.
Console.WriteLine(numberOfTurns % 2 == 0 ? "Malvika" : "Akshat");
