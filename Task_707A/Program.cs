/* 
 * Task 707A
 * 
 * https://codeforces.com/problemset/problem/707/A
 */

string[] input = Console.ReadLine().Split(' ');
int rows = int.Parse(input[0]);
int cols = int.Parse(input[1]);

for (int i = 0; i < rows; i++)
{
    char[] pixels =
        Array.ConvertAll(Console.ReadLine().Split(' '), v => char.Parse(v));

    if (pixels.Contains('C') ||
        pixels.Contains('M') ||
        pixels.Contains('Y'))
    {
        Console.WriteLine("#Color");
        return;
    }
}

Console.WriteLine("#Black&White");
