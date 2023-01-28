/* 
 * Task 118A
 * 
 * https://codeforces.com/problemset/problem/118/A 
 */

using System.Text.RegularExpressions;

internal class Program
{
    private static void Main(string[] args)
    {
        // Read the source string.
        string input = Console.ReadLine();

        // Remove vowels.
        string result = RemoveVowels(input);

        // Convert all chars to lowercase.
        result = result.ToLower();

        // Since all the remained chars are consonants,
        // just write them down with a dot in front of each character.
        foreach (var c in result)
        {
            Console.Write($".{c}");
        }
    }

    /// <summary>
    /// Removes vowels from string.
    /// </summary>
    /// <param name="text">Source string</param>
    /// <returns>String without vowels.</returns>
    private static string RemoveVowels(string text)
    {
        return new Regex(@"[AOYEUIaoyeui]").Replace(text, string.Empty);
    }
}
