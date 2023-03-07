/* 
 * Task 34B
 * 
 * https://codeforces.com/problemset/problem/34/B
 */

int[] input =
    Array.ConvertAll(Console.ReadLine().Split(' '), v => int.Parse(v));
int numberOfTVs = input[0];
int maxCapacity = input[1];

input = Array.ConvertAll(Console.ReadLine().Split(' '), v => int.Parse(v));
Array.Sort(input);

int sum = 0;
for (int i = 0; i < maxCapacity; i++)
{
    if (input[i] < 0)
    {
        sum -= input[i];
    }
}

Console.WriteLine(sum);
