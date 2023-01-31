/* 
 * Task 208A
 * 
 * https://codeforces.com/problemset/problem/208/A
 */

using System.Text.RegularExpressions;

// Read the modified string.
string dubstepSongText = Console.ReadLine();

// Find the source string.
string originalSongText = dubstepSongText.Replace("WUB", " ");
originalSongText = originalSongText.Trim();
originalSongText = Regex.Replace(originalSongText, @"\s+", " ");

// Write the result.
Console.WriteLine(originalSongText);
