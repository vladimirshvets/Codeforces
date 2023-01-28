/* 
 * Task 236A
 * 
 * https://codeforces.com/problemset/problem/236/A 
 */

// Read the username.
string username = Console.ReadLine();

// Store unique chars.
List<char> uniqueChars = new();

foreach (var c in username)
{
    if (!uniqueChars.Contains(c))
    {
        uniqueChars.Add(c);
    }
}

// Write the result.
if (uniqueChars.Count() % 2 == 0)
{
    Console.WriteLine("CHAT WITH HER!");
}
else
{
    Console.WriteLine("IGNORE HIM!");
}
