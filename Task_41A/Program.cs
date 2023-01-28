/* 
 * Task 41A
 * 
 * https://codeforces.com/problemset/problem/41/A 
 */

// Read the word and its "translation" (reversed word).
string word = Console.ReadLine();
string reversedWord = Console.ReadLine();

bool isCorrectTranslation = true;

// IMPORTANT: task description doesn't contain any statements
// about the equality of string lengths.
if (word.Length == reversedWord.Length)
{
    for (int i = 0; i < word.Length; i++)
    {
        if (!word[i].Equals(reversedWord[word.Length - i - 1]))
        {
            isCorrectTranslation = false;
            break;
        }
    }
}
else
{
    isCorrectTranslation = false;
}

// Write the result.
Console.WriteLine(isCorrectTranslation ? "YES" : "NO");
