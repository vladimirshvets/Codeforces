/* 
 * Task 112A
 * 
 * https://codeforces.com/problemset/problem/112/A 
 */

// Read two strings.
string stringOne = Console.ReadLine();
string stringTwo = Console.ReadLine();

int comparisionResult =
    String.Compare(stringOne, stringTwo, StringComparison.OrdinalIgnoreCase);

// Write the result.
switch (comparisionResult)
{
    case < 0:
        Console.WriteLine(-1);
        break;

    case > 0:
        Console.WriteLine(1);
        break;

    default:
        Console.WriteLine(0);
        break;
}