/* 
 * Task 141A
 * 
 * https://codeforces.com/problemset/problem/141/A
 */

// Read the Santas' names and available letters.
string nameOne = Console.ReadLine();
string nameTwo = Console.ReadLine();
string availableLetters = Console.ReadLine();

// Concatenate letters from two names.
string sourceSetOfLetters = String.Concat(nameOne, nameTwo);

// Sort letters in original and assumed sets.
string sortedSourceSetOfLetters =
    String.Concat(sourceSetOfLetters.OrderBy(c => c));
string sortedSetOfAvailableLetters =
    String.Concat(availableLetters.OrderBy(c => c));

// Write the result.
Console.WriteLine(
    sortedSourceSetOfLetters == sortedSetOfAvailableLetters ? "YES" : "NO");