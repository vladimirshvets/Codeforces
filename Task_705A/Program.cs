/* 
 * Task 705A
 * 
 * https://codeforces.com/problemset/problem/705/A
 */

// Read the number of level.
int levelNumber = int.Parse(Console.ReadLine());

// Produce the phrase.
string phrase = string.Empty;
for (int i = 1; i <= levelNumber; i++)
{
    phrase += (i % 2 == 1) ? "I hate " : "I love ";
    phrase += (i == levelNumber) ? "it " : "that ";
}
phrase = phrase.TrimEnd();

// Write the result.
Console.WriteLine(phrase);
