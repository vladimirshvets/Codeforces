/* 
 * Task 363B
 * 
 * https://codeforces.com/problemset/problem/363/B
 */

// Read the number of planks, their heights,
// and piano width.
string[] input = Console.ReadLine().Split(' ');
int numberOfPlanks = int.Parse(input[0]);
int pianoWidth = int.Parse(input[1]);
int[] planks =
    Array.ConvertAll(Console.ReadLine().Split(' '), v => int.Parse(v));

// Build the matrix of solutions.
int[] intervalTotals = new int[numberOfPlanks];
for (int i = numberOfPlanks - 1; i >= 0; i--)
{
    intervalTotals[i] = planks[i];
    if (i + 1 < numberOfPlanks)
    {
        intervalTotals[i] += intervalTotals[i + 1];
    }
    if (i + pianoWidth < numberOfPlanks)
    {
        intervalTotals[i] -= planks[i + pianoWidth];
    }
}

// Find the minimum value and its index.
int minSumValue = intervalTotals[0];
int minSumIndex = 0;
for (int i = 1; i <= numberOfPlanks - pianoWidth; i++)
{
    if (intervalTotals[i] < minSumValue)
    {
        minSumValue = intervalTotals[i];
        minSumIndex = i;
    }
}

// Write the result.
Console.WriteLine(minSumIndex + 1);
