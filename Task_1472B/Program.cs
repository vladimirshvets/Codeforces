/* 
 * Task 1472B
 * 
 * https://codeforces.com/problemset/problem/1360/B
 */

// Read the number of tests.
int numberOfTests = int.Parse(Console.ReadLine());

for (int i = 0; i < numberOfTests; i++)
{
    // Read the number of sweets and their weights.
    int numberOfSweets = int.Parse(Console.ReadLine());
    int[] weights =
        Array.ConvertAll(Console.ReadLine().Split(' '), v => int.Parse(v));

    int numberOfOnes = 0;
    int numberOfTwos = 0;
    foreach (int weight in weights)
    {
        switch (weight)
        {
            case 1:
                numberOfOnes++;
                break;

            case 2:
                numberOfTwos++;
                break;
        }
    }

    // Condition 1: Weight value is even.
    // Condition 2: We have no "ones" or at least two "ones".
    int totalWeight = numberOfTwos * 2 + numberOfOnes;
    if (totalWeight % 2 != 0 ||
        (totalWeight % 4 != 0 && numberOfOnes == 0))
    {
        Console.WriteLine("NO");
    }
    else
    {
        Console.WriteLine("YES");
    }
}
