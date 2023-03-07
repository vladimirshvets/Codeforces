/* 
 * Task 1371A
 * 
 * https://codeforces.com/problemset/problem/1371/A
 */

int numberOfTests = int.Parse(Console.ReadLine());

for (int i = 0; i < numberOfTests; i++)
{
    int numberOfSticks = int.Parse(Console.ReadLine());
    Console.WriteLine((numberOfSticks + 1) / 2);
}
