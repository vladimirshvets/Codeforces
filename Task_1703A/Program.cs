/* 
 * Task 1703A
 * 
 * https://codeforces.com/problemset/problem/1703/A
 */

int numberOfTests = int.Parse(Console.ReadLine());
for (int i = 0; i < numberOfTests; i++)
{
    Console.WriteLine(Console.ReadLine().ToUpper() == "YES" ? "YES" : "NO");
}
