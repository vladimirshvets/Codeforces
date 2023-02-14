/* 
 * Task 472A
 * 
 * https://codeforces.com/problemset/problem/472/A
 */

int value = int.Parse(Console.ReadLine());

if (value % 2 == 0)
{
    Console.WriteLine($"{4} {value - 4}");
}
else
{
    Console.WriteLine($"{9} {value - 9}");
}
