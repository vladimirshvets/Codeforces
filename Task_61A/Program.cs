/* 
 * Task 61A
 * 
 * https://codeforces.com/problemset/problem/61/A
 */

// Read the numbers.
string numberOne = Console.ReadLine();
string numberTwo = Console.ReadLine();
string resultNumber = string.Empty;

// Compare digits one by one.
for (int i = 0; i < numberOne.Length; i++)
{
    if (numberOne[i].Equals(numberTwo[i]))
    {
        resultNumber += '0';
    }
    else
    {
        resultNumber += '1';
    }
}

// Write the result.
Console.WriteLine(resultNumber);