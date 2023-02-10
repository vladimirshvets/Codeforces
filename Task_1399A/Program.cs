/* 
 * Task 1399A
 * 
 * https://codeforces.com/problemset/problem/1399/A 
 */

int numberOfTests = int.Parse(Console.ReadLine());

for (int i = 0; i < numberOfTests; i++)
{
    int numberOfValues = int.Parse(Console.ReadLine());
    int[] values =
        Array.ConvertAll(Console.ReadLine().Split(' '), v => int.Parse(v));
    Array.Sort(values);
    bool canTransform = true;
    for (int j = 0; j < numberOfValues - 1; j++)
    {
        if (Math.Abs(values[j] - values[j + 1]) > 1)
        {
            canTransform = false;
            break;
        }
    }

    Console.WriteLine(canTransform ? "YES" : "NO");
}
