/* 
 * Task 59A
 * 
 * https://codeforces.com/problemset/problem/59/A 
 */

// Read the input string.
string input = Console.ReadLine();

// Count all chars written in uppercase.
int numberOfUpper = 0;
foreach (var c in input)
{
    if (char.IsUpper(c))
    {
        numberOfUpper++;
    }
}

// Write the result.
if (numberOfUpper > input.Length - numberOfUpper)
{
    Console.WriteLine(input.ToUpper());
}
else
{
    Console.WriteLine(input.ToLower());
}
