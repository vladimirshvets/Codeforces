/* 
 * Task 489C
 * 
 * https://codeforces.com/problemset/problem/489/C
 */

using System.Text;

// Read the number of digits and their sum.
string[] input = Console.ReadLine().Split(' ');
int numberOfDigits = int.Parse(input[0]);
int sumOfDigits = int.Parse(input[1]);

if (sumOfDigits == 0 && numberOfDigits > 1 ||
    numberOfDigits * 9 < sumOfDigits)
{
    // Cover cases where there is no solution.
    Console.WriteLine("-1 -1");
}
else
{
    // Build the minimum value (with trailing nines)
    // and the maximum value (with leading nines).
    StringBuilder sMin = new StringBuilder(numberOfDigits);
    StringBuilder sMax = new StringBuilder(numberOfDigits);

    for (int i = 0; i < numberOfDigits; i++)
    {
        sMin.Append('0');
        sMax.Append('0');
    }

    int minValIndex = numberOfDigits - 1;
    int maxValIndex = 0;
    while (sumOfDigits > 9)
    {
        sMin[minValIndex--] = '9';
        sMax[maxValIndex++] = '9';
        sumOfDigits -= 9;
    }

    sMax[maxValIndex] = (char)(sumOfDigits + (int)'0');

    // The leading digit shouldn't be zero.
    if (minValIndex == 0)
    {
        sMin[minValIndex] = (char)(sumOfDigits + (int)'0');
    }
    else
    {
        sMin[0] = '1';
        sMin[minValIndex] = (char)(sumOfDigits - 1 + (int)'0');
    }

    // Write the result.
    Console.WriteLine($"{sMin.ToString()} {sMax.ToString()}");
}
