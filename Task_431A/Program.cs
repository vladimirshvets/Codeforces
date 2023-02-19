/* 
 * Task 431A
 * 
 * https://codeforces.com/problemset/problem/431/A
 */

int[] calories =
    Array.ConvertAll(Console.ReadLine().Split(' '), v => int.Parse(v));
string stripes = Console.ReadLine();

int totalCalories = 0;
foreach (char stripe in stripes)
{
    totalCalories += stripe switch
    {
        '1' => calories[0],
        '2' => calories[1],
        '3' => calories[2],
        '4' => calories[3]
    };
}

Console.WriteLine(totalCalories);
