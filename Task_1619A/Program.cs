/* 
 * Task 1619A
 * 
 * https://codeforces.com/problemset/problem/1619/A
 */

int numberOfTests = int.Parse(Console.ReadLine());

for (int i = 0; i < numberOfTests; i++)
{
    string str = Console.ReadLine();
    int halfLength = str.Length / 2;
    string result =
        str.Substring(0, halfLength) == str.Substring(halfLength)
        ? "YES"
        : "NO";
    Console.WriteLine(result);
}
