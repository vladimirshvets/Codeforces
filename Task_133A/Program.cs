/* 
 * Task 133A
 * 
 * https://codeforces.com/problemset/problem/133/A
 */

// Read the code.
string code = Console.ReadLine();

// If the code contains any of "H", "Q", "9" chars, then the program has output.
bool hasOutput = false;
if (code.Contains('H') || code.Contains('Q') || code.Contains('9'))
{
    hasOutput = true;
}

// Write the result.
Console.WriteLine(hasOutput ? "YES" : "NO");
