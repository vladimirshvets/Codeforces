/* 
 * Task 1778C
 * 
 * https://codeforces.com/problemset/problem/1778/C
 * 
 * NOTE: Works too slow to pass tests. Requires optimization or rewriting.
 */

internal class Program
{
    private static void Main(string[] args)
    {
        // Read the number of tests.
        int numberOfTests = int.Parse(Console.ReadLine());
        for (int i = 0; i < numberOfTests; i++)
        {
            // Read the word length and max size of multitude.
            string input = Console.ReadLine();
            string[] separatedInput = input.Split(' ');
            int wordLength = int.Parse(separatedInput[0]);
            int multitudeMaxSize = int.Parse(separatedInput[1]);
            string sourceWord = Console.ReadLine();
            string finalWord = Console.ReadLine();

            // Create a list of unique letters from the source word
            // that are different from letters on corresponding positions
            // in final word.
            List<char> uniqueChars = new();
            for (int j = 0; j < sourceWord.Length; j++)
            {
                if (!sourceWord[j].Equals(finalWord[j]) &&
                    !uniqueChars.Contains(sourceWord[j]))
                {
                    uniqueChars.Add(sourceWord[j]);
                }
            }

            int numberOfPairs = 0;

            // Generate possible subsets of letters.
            foreach (var iteration in GetBinaryEnumerator(uniqueChars.Count()))
            {
                // Use only iterations of multitudeMaxSize length.
                if (iteration.Where(i => i.Equals(true)).Count() !=
                    Math.Min(multitudeMaxSize, uniqueChars.Count()))
                {
                    continue;
                }

                // Generate a list of letters that can be changed
                // on this iteration.
                List<char> currentUniqueChars = new();
                for (int c = 0; c < iteration.Count(); c++)
                {
                    if (iteration[c])
                    {
                        currentUniqueChars.Add(uniqueChars[c]);
                    }
                }

                // Produce subwords and check if they contain letters
                // that can be changed.
                int currentNumberOfPairs = 0;
                for (int j = 0; j < wordLength; j++)
                {
                    for (int k = j; k < wordLength; k++)
                    {
                        bool canModifySubword = true;
                        string sourceSubword = sourceWord.Substring(j, k - j + 1);
                        string finalSubword = finalWord.Substring(j, k - j + 1);

                        for (int l = 0; l < sourceSubword.Length; l++)
                        {
                            if (!currentUniqueChars.Contains(sourceSubword[l]) &&
                                !sourceSubword[l].Equals(finalSubword[l]))
                            {
                                canModifySubword = false;
                                break;
                            }
                        }

                        if (canModifySubword)
                        {
                            currentNumberOfPairs++;
                            // Console.WriteLine(sourceSubword);
                        }
                    }
                }

                if (currentNumberOfPairs > numberOfPairs)
                {
                    numberOfPairs = currentNumberOfPairs;
                }
            }

            // Write the result for each test.
            Console.WriteLine(numberOfPairs);
        }
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
}
