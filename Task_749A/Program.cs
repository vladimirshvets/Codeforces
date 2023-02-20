/* 
 * Task 749A
 * 
 * https://codeforces.com/problemset/problem/749/A
 */

int value = int.Parse(Console.ReadLine());

int numberOfSummands = value / 2;
Console.WriteLine(numberOfSummands);
for (int i = 0; i < numberOfSummands - 1; i++)
{
    Console.Write($"2 ");
}
Console.WriteLine(value % 2 == 0 ? 2 : 3);
