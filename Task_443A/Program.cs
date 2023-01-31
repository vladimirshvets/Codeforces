/* 
 * Task 443A
 * 
 * https://codeforces.com/problemset/problem/443/A
 */

using System.Text.RegularExpressions;

// Read the phrase.
string phrase = Console.ReadLine();

// Remove useless chars from the string.
phrase = Regex.Replace(phrase, @"[{}, ]", string.Empty);

// Distinguish unique chars.
List<char> uniqueChars = new();
for (int i = 0; i < phrase.Length; i++)
{
    if (!uniqueChars.Contains(phrase[i]))
    {
        uniqueChars.Add(phrase[i]);
    }
}

// Write the result.
Console.WriteLine(uniqueChars.Count());
