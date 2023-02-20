/* 
 * Task 1669A
 * 
 * https://codeforces.com/problemset/problem/1669/A
 */

int numberOfTests = int.Parse(Console.ReadLine());

for (int i = 0; i < numberOfTests; i++)
{
    int rating = int.Parse(Console.ReadLine());
    byte division = rating switch
    {
        >= 1900             => 1,
        >= 1600 and < 1900  => 2,
        >= 1400 and < 1600  => 3,
        < 1400              => 4
    };

    Console.WriteLine($"Division {division}");
}
