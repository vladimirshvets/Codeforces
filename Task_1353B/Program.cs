/* 
 * Task 1353B
 * 
 * https://codeforces.com/problemset/problem/1353/B
 */

// Read the number of tests.
byte numberOfTests = byte.Parse(Console.ReadLine());

for (byte i = 0; i < numberOfTests; i++)
{
    // Read the number of values, maximum number of exchanges
    // and values themselves.
    string[] input = Console.ReadLine().Split(' ');
    byte numberOfValues = byte.Parse(input[0]);
    byte maxNumberOfExchanges = byte.Parse(input[1]);
    int[] valuesA =
        Array.ConvertAll(Console.ReadLine().Split(' '), v => int.Parse(v));
    int[] valuesB =
        Array.ConvertAll(Console.ReadLine().Split(' '), v => int.Parse(v));

    // Get the biggest elements from the second array and put them
    // to the first array instead of its lowest elements.
    Array.Sort(valuesA);
    Array.Sort(valuesB);
    for (
        byte j = 0;
        (j < valuesB.Length) && (j < maxNumberOfExchanges) &&
        (valuesA[j] < valuesB[valuesB.Length - j - 1]);
        j++)
    {
        valuesA[j] = valuesB[valuesB.Length - j - 1];
    }

    // Write the result.
    Console.WriteLine(valuesA.Sum());
}
