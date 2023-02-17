/* 
 * Task 456C
 * 
 * Duplicates 455A.
 * 
 * https://codeforces.com/problemset/problem/456/C
 */

// Read the number of values and values themselves.
int numberOfValues = int.Parse(Console.ReadLine());
int[] values =
    Array.ConvertAll(Console.ReadLine().Split(' '), v => int.Parse(v));
Array.Sort(values);

// Store unique elements and their qty.
Dictionary<int, int> uniqueElements = new();
foreach (int value in values)
{
    if (uniqueElements.ContainsKey(value))
    {
        uniqueElements[value]++;
    }
    else
    {
        uniqueElements.Add(value, 1);
    }
}

// Find the maximum score.
long prevPrevScore = 0;
long prevScore = 0;
long currentScore = 0;
int i = 1;
int maxElement = uniqueElements.Last().Key;
while (i <= maxElement)
{
    prevPrevScore += (long)i * uniqueElements.GetValueOrDefault(i);
    currentScore = Math.Max(prevScore, prevPrevScore);

    prevPrevScore = prevScore;
    prevScore = currentScore;
    i++;
}

// Write the result.
Console.WriteLine(currentScore);
