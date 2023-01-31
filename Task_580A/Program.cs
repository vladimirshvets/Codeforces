/* 
 * Task 580A
 * 
 * https://codeforces.com/problemset/problem/580/A
 */

// Read the number of days and income per each day.
int numberOfDays = int.Parse(Console.ReadLine());
string input = Console.ReadLine();
string[] separatedInput = input.Split(' ');
int[] earnings = Array.ConvertAll(separatedInput, e => int.Parse(e));

// Search for the subsequence of a maximum length.
int maxSubsequenceLength = 0;
int subsequenceStart = 0;
while (subsequenceStart < numberOfDays)
{
    int currentSubsequenceLength = 1;
    for (int i = subsequenceStart + 1; i < numberOfDays; i++)
    {
        if (earnings[i] < earnings[i - 1])
        {
            break;
        }
        currentSubsequenceLength++;
    }

    if (currentSubsequenceLength > maxSubsequenceLength)
    {
        maxSubsequenceLength = currentSubsequenceLength;
    }
    subsequenceStart += currentSubsequenceLength;
}

// Write the result.
Console.WriteLine(maxSubsequenceLength);
