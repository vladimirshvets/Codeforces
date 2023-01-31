/* 
 * Task 520A
 * 
 * https://codeforces.com/problemset/problem/520/A
 */

// Read the phrase and its length.
int phraseLength = int.Parse(Console.ReadLine());
string phrase = Console.ReadLine();

// Distinguish unique chars.
phrase = phrase.ToLower();
List<char> uniqueChars = new();
for (int i = 0; i < phraseLength; i++)
{
    if (!uniqueChars.Contains(phrase[i]))
    {
        uniqueChars.Add(phrase[i]);
    }
}

// Write the result.
Console.WriteLine(uniqueChars.Count() == 26 ? "YES" : "NO");
