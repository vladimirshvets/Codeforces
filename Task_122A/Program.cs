/* 
 * Task 122A
 * 
 * https://codeforces.com/problemset/problem/122/A 
 */

internal class Program
{
    private static void Main(string[] args)
    {
        // Read the number to test of luck.
        int numberToCheck = int.Parse(Console.ReadLine());

        // Use lucky number generator to check if the entered number
        // can be divided by any of lucky numbers.
        bool isAlmostLucky = false;
        foreach (int luckyNumber in ProduceLuckyNumbers(numberToCheck))
        {
            if (numberToCheck % luckyNumber == 0)
            {
                isAlmostLucky = true;
                break;
            }
        }

        // Write the result.
        Console.WriteLine(isAlmostLucky ? "YES" : "NO");
    }

    /// <summary>
    /// Lucky numbers iterator.
    /// </summary>
    /// <param name="upTo">Upper number limit.</param>
    /// <returns>Lucky numbers.</returns>
    private static IEnumerable<int> ProduceLuckyNumbers(int upTo)
    {
        string luckyNumberString = string.Empty;
        int luckyNumber = 0;

        while (luckyNumber <= upTo)
        {
            // Generate next lucky number.
            int lastIndexOfFour = luckyNumberString.LastIndexOf('4');
            if (lastIndexOfFour >= 0)
            {
                // Copy leading digits.
                string nextLuckyNumberString =
                    luckyNumberString.Substring(0, lastIndexOfFour);
                // Update 4 to 7.
                nextLuckyNumberString += '7';
                // Update trailing digits '7' to '4'.
                nextLuckyNumberString = nextLuckyNumberString.PadRight(
                    luckyNumberString.Length, '4');

                luckyNumberString = nextLuckyNumberString;
            }
            else
            {
                // Increase the number lenght and update all digits to '4'.
                luckyNumberString =
                    string.Empty.PadRight(luckyNumberString.Length + 1, '4');
            }

            luckyNumber = int.Parse(luckyNumberString);

            if (luckyNumber > upTo)
            {
                yield break;
            }

            yield return luckyNumber;
        }
    }
}
