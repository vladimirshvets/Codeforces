/* 
 * Task 579A
 * 
 * https://codeforces.com/problemset/problem/579/A
 */

// Read the number of bacteria.
int value = int.Parse(Console.ReadLine());

// Assume the number as the sum of powers of two.
int minQty = 0;
while (value > 0)
{
    int nearestPowerOfTwo = (int)(Math.Log(value) / Math.Log(2));
    value -= (int)Math.Pow(2, nearestPowerOfTwo);
    minQty++;
}

// Write the result.
Console.WriteLine(minQty);
