/* 
 * Task 1742A
 * 
 * https://codeforces.com/problemset/problem/1742/A
 */

int numberOfTests = int.Parse(Console.ReadLine());

for (int i = 0; i < numberOfTests; i++)
{
    int[] values =
        Array.ConvertAll(Console.ReadLine().Split(' '), v => int.Parse(v));
    Array.Sort(values);

    Console.WriteLine(values[0] + values[1] == values[2] ? "YES" : "NO");
}
