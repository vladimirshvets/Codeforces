/* 
 * Task 266A
 * 
 * https://codeforces.com/problemset/problem/266/A 
 */

// Read the number of stones - integer value in range [1..50].
int N = int.Parse(Console.ReadLine());

// Read the sequence of stones.
string sequence = Console.ReadLine();

// The number of stones that should be removed.
int numberOfStonesToRemove = 0;

// Initialize the subsequence color with the first stone's color.
char subsequenceColor = sequence[0];

int subsequenceStartPosition = 0;

// Add non-RGB char to the end to take the last subsequence into account.
sequence = $"{sequence}.";

// To meet the requirements, it's necessary to find a subsequence of stones
// of the same color and remove all except one.
for (int i = 0; i < sequence.Length; i++)
{
    if (!sequence[i].Equals(subsequenceColor))
    {
        numberOfStonesToRemove += i - subsequenceStartPosition - 1;
        subsequenceStartPosition = i;
        subsequenceColor = sequence[i];
    }
}

// Write the result.
Console.WriteLine(numberOfStonesToRemove);
