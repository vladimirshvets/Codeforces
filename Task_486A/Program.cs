/* 
 * Task 486A
 * 
 * https://codeforces.com/problemset/problem/486/A
 */

long number = long.Parse(Console.ReadLine());
long functionResult;

if (number % 2 == 0)
{
    functionResult = number / 2;
}
else
{
    functionResult = -(number / 2 + 1);
}

Console.WriteLine(functionResult);
