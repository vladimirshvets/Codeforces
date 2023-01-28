/* 
 * Task 110A
 * 
 * https://codeforces.com/problemset/problem/110/A 
 */

// Read a long integer value as a string to avoid multiple divisions.
string longNumber = Console.ReadLine();

// Calculate the number of "lucky" digits (4, 7) in the initial number.
int numberOfLuckyDigits = 0;
foreach (var c in longNumber)
{
    if ((c == '4') || (c == '7'))
    {
        numberOfLuckyDigits++;
    }
}

// Determine whether the number of lucky digits is lucky.
bool isNumberLucky = true;
do
{
    int lastDigit = numberOfLuckyDigits % 10;
    if ((lastDigit != 4) && (lastDigit != 7))
    {
        isNumberLucky = false;
        break;
    }
    numberOfLuckyDigits /= 10;
}
while (numberOfLuckyDigits > 0);

// Write the result.
Console.WriteLine(isNumberLucky ? "YES" : "NO");
