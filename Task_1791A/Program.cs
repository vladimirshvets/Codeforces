/* 
 * Task 1791A
 * 
 * https://codeforces.com/problemset/problem/1791/A
 */

string codeforces = "codeforces";
int numberOfTests = int.Parse(Console.ReadLine());
for (int i = 0; i < numberOfTests; i++)
{
    char letter = char.Parse(Console.ReadLine());
    Console.WriteLine(codeforces.Contains(letter) ? "YES" : "NO");
}
