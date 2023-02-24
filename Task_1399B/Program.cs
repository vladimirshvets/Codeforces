/* 
 * Task 1399B
 * 
 * https://codeforces.com/problemset/problem/1399/B
 */

int numberOfTests = int.Parse(Console.ReadLine());

for (int i = 0; i < numberOfTests; i++)
{
    byte numberOfGifts = byte.Parse(Console.ReadLine());
    int[] sweets =
        Array.ConvertAll(Console.ReadLine().Split(' '), v => int.Parse(v));
    int[] oranges =
        Array.ConvertAll(Console.ReadLine().Split(' '), v => int.Parse(v));

    int minNumberOfSweets = sweets.Min();
    int minNumberOfOranges = oranges.Min();
    long numberOfActions = 0;

    for (int j = 0; j < numberOfGifts; j++)
    {
        int sweetsToEat = sweets[j] - minNumberOfSweets;
        int orangesToEat = oranges[j] - minNumberOfOranges;
        numberOfActions += Math.Max(sweetsToEat, orangesToEat);
    }

    Console.WriteLine(numberOfActions);
}
