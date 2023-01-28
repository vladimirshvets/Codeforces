/* 
 * Task 281A
 * 
 * https://codeforces.com/problemset/problem/281/A 
 */

// Read the source string.
string input = Console.ReadLine();

// Capitalize the first letter.
string capitalizedWord = input[0].ToString().ToUpper();
capitalizedWord += input.Substring(1);

// Write the result.
Console.WriteLine(capitalizedWord);
