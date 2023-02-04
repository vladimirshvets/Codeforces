/* 
 * Task 581A
 * 
 * https://codeforces.com/problemset/problem/581/A
 */

// Read the number of socks.
string input = Console.ReadLine();
string[] separatedInput = input.Split(' ');
int numberOfRedSocks = int.Parse(separatedInput[0]);
int numberOfBlueSocks = int.Parse(separatedInput[1]);

// Calculate the number of pairs of two colors.
int numberOfTwoColorPairs = Math.Min(numberOfRedSocks, numberOfBlueSocks);
// Calculate the number of pairs of one color using the rest of socks.
int numberOfOneColorPairs =
    (Math.Max(numberOfRedSocks, numberOfBlueSocks) - numberOfTwoColorPairs) / 2;

// Write the result.
Console.WriteLine($"{numberOfTwoColorPairs} {numberOfOneColorPairs}");
