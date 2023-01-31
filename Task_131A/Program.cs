/* 
 * Task 131A
 * 
 * https://codeforces.com/problemset/problem/131/A
 */

// Read the source string.
string phrase = Console.ReadLine();

// Determine if the CapsLock was active. Check all letters except the first one.
bool isCapsLockActive = true;
for (int i = 1; i < phrase.Length; i++)
{
    if (char.IsLower(phrase[i]))
    {
        isCapsLockActive = false;
        break;
    }
}

// Update letters if the CapsLock was active.
string modifiedPhrase = string.Empty;
if (isCapsLockActive)
{
    for (int i = 0; i < phrase.Length; i++)
    {
        if (char.IsLower(phrase[i]))
        {
            modifiedPhrase += char.ToUpper(phrase[i]);
        }
        else
        {
            modifiedPhrase += char.ToLower(phrase[i]);
        }
    }
}
else
{
    modifiedPhrase = phrase;
}

// Write the result.
Console.WriteLine(modifiedPhrase);
