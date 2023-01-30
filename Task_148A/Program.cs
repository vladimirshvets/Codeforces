/* 
 * Task 148A
 * 
 * https://codeforces.com/problemset/problem/148/A
 */

using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        // Read the positions of dragons and total number of dragons.
        var affectedPositions = new int[4];
        for (int i = 0; i < 4; i++)
        {
            affectedPositions[i] = int.Parse(Console.ReadLine());
        }
        int totalNumberOfDragons = int.Parse(Console.ReadLine());
        int numberOfDragonsToHurt = 0;

        // NOTE: greatest common divisor (GCD) and
        // least common multiple (LCM) are used in calculations
        // to make this solution more generic.
        // Thus, produce all combinations of values.
        foreach (bool[] binaryCombination in GetBinaryEnumerator(4))
        {
            List<int> currentListOfValues = new();
            for (int i = 0; i < binaryCombination.Length; i++)
            {
                if (binaryCombination[i])
                {
                    currentListOfValues.Add(affectedPositions[i]);
                }
            }

            int currentCombinationCount = currentListOfValues.Count();
            if (currentCombinationCount == 0)
            {
                continue;
            }

            if (currentCombinationCount % 2 == 0)
            {
                numberOfDragonsToHurt -=
                    totalNumberOfDragons / LCM(currentListOfValues);
            } else
            {
                numberOfDragonsToHurt +=
                    totalNumberOfDragons / LCM(currentListOfValues);
            }
        }

        // Write the result.
        Console.WriteLine(numberOfDragonsToHurt);
        
    }

    /// <summary>
    /// Binary combination generator.
    /// </summary>
    /// <param name="numberOfBits">Number of bits</param>
    /// <returns>All bit combination iterations.</returns>
    private static IEnumerable<bool[]> GetBinaryEnumerator(int numberOfBits)
    {
        var binaryCombination = new bool[numberOfBits];

        while (true)
        {
            yield return binaryCombination;

            int lastZeroBitPosition =
                Array.LastIndexOf(binaryCombination, false);

            // All bits are 1, no further iterations required.
            if (lastZeroBitPosition < 0)
            {
                yield break;
            }

            // Produce next iteration.
            binaryCombination[lastZeroBitPosition] = true;
            for (int i = lastZeroBitPosition + 1; i < numberOfBits; i++)
            {
                binaryCombination[i] = false;
            }
        }
    }

    /// <summary>
    /// Calculates the least common multiple of numbers.
    /// </summary>
    /// <param name="values">The list of numbers</param>
    /// <returns>Value of LCM.</returns>
    private static int LCM(List<int> values)
    {
        switch (values.Count())
        {
            case 1:
                return values[0];

            case 2:
                return values[0] * values[1] / GCD(values[0], values[1]);

            default:
                int subLcm = LCM(values.GetRange(1, values.Count() - 1));
                return values[0] * subLcm / GCD(values[0], subLcm);
        }
    }

    /// <summary>
    /// Calculates the greatest common divisors of two numbers.
    /// </summary>
    /// <param name="valueOne">First value</param>
    /// <param name="valueTwo">Second value</param>
    /// <returns>Value of GCD.</returns>
    private static int GCD(int valueOne, int valueTwo)
    {
        if (valueTwo == 0)
        {
            return valueOne;
        }
        else
        {
            return GCD(valueTwo, valueOne % valueTwo);
        }
    }
}
