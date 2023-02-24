/* 
 * Task 1475B
 * 
 * https://codeforces.com/problemset/problem/1475/B
 */

int numberOfTests = int.Parse(Console.ReadLine());

for (int i = 0; i < numberOfTests; i++)
{
    int value = int.Parse(Console.ReadLine());
    int numberOfSummands = value / 2020;
    int rest = value % 2020;
    if (rest <= numberOfSummands)
    {
        Console.WriteLine("YES");
    }
    else
    {
        Console.WriteLine("NO");
    }
}
