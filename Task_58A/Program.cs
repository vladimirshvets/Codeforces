/* 
 * Task 58A
 * 
 * https://codeforces.com/problemset/problem/58/A 
 */

internal class Program
{
    /// <summary>
    /// Sample string
    /// </summary>
    private static readonly string sample = "hello";

    private static void Main(string[] args)
    {
        // Read the long word.
        string input = Console.ReadLine();

        // Search for result.
        bool canHighlight = CanHighlightASubstring(input, sample);

        // Write the result.
        Console.WriteLine(canHighlight ? "YES" : "NO");        
    }

    /// <summary>
    /// Checks if the string contains the letters which can be highlighted
    /// to get the specified substring.
    /// </summary>
    /// <param name="source">The source string</param>
    /// <param name="substring">The substring</param>
    /// <returns>true if the substring can be highlighted
    /// in the source string.</returns>
    private static bool CanHighlightASubstring(string source, string substring)
    {
        // Search the first letter of the substring in the source string.
        char letterToSearch = substring[0];
        int letterIndex = source.IndexOf(letterToSearch);
        if (letterIndex >= 0)
        {
            // The whole substring can be highlighted.
            if (substring.Length == 1)
            {
                return true;
            }

            // Search a new substring in a new source recursively.
            return CanHighlightASubstring(
                source.Substring(letterIndex + 1), substring.Substring(1));
        }

        // The substring can't be highlighted.
        return false;
    }
}
