/* 
 * Task 270A
 * 
 * https://codeforces.com/problemset/problem/270/A 
 */

int numberOfTests = int.Parse(Console.ReadLine());

for (int i = 0; i < numberOfTests; i++)
{
    int angle = int.Parse(Console.ReadLine());
    Console.WriteLine(360 % (180 - angle) == 0  ? "YES" : "NO");
}
