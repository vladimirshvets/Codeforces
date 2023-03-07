/* 
 * Task 1352C
 * 
 * https://codeforces.com/problemset/problem/1352/C
 */

int numberOfTests = int.Parse(Console.ReadLine());

for (int i = 0; i < numberOfTests; i++)
{
    string[] input = Console.ReadLine().Split(' ');
    int n = int.Parse(input[0]);
    int k = int.Parse(input[1]);

    int result = k + (int)Math.Truncate((decimal)(k - 1) / (n - 1));
    Console.WriteLine(result);
}
