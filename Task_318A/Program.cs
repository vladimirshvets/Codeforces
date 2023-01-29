/* 
 * Task 318A
 * 
 * https://codeforces.com/problemset/problem/318/A
 */

// Read the specified value and position.
string input = Console.ReadLine();
string[] separatedInput = input.Split(' ');
long value = long.Parse(separatedInput[0]);
long position = long.Parse(separatedInput[1]);

// Determine if the result value is even or odd.
long lastOddPosition;
if (value % 2 == 0)
{
    lastOddPosition = value / 2;
}
else
{
    lastOddPosition = value / 2 + 1;
}

// Calculate the result based on position.
long resultValue;
if (position <= lastOddPosition)
{
    resultValue = position * 2 - 1;
}
else
{
    resultValue = (position - lastOddPosition) * 2;
}

// Write the result.
Console.WriteLine(resultValue);
