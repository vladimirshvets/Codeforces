/* 
 * Task 1283A
 * 
 * https://codeforces.com/problemset/problem/1283/A 
 */

int numberOfTests = int.Parse(Console.ReadLine());
for (int i = 0; i < numberOfTests; i++)
{
    string[] input = Console.ReadLine().Split(' ');
    int hours = int.Parse(input[0]);
    int mins = int.Parse(input[1]);

    Console.WriteLine((23 - hours) * 60 + (60 - mins));
}