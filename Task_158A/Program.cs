/* 
 * Task 158A
 * 
 * https://codeforces.com/problemset/problem/158/A 
 */

// Number of participants in shortlist
int shortlistedParticipantsNumber = 0;

// Read the number of participants and the number of place -
// integer values in range [1..50].
string input = Console.ReadLine();
string[] inputSeparatedValues = input.Split(' ');
int N = int.Parse(inputSeparatedValues[0]);
int K = int.Parse(inputSeparatedValues[1]);

// Read the scores (sorted in descending order by task conditions).
input = Console.ReadLine();
string[] scoresInputSeparatedValues = input.Split(' ');
int[] scores = Array.ConvertAll(scoresInputSeparatedValues, int.Parse);

if (scores[K - 1] == 0)
{
    // Participants with zero score can't be shortlisted.
    for (var i = K - 2; i >= 0; i--)
    {
        if (scores[i] != 0)
        {
            shortlistedParticipantsNumber = i + 1;
            break;
        }
    }
}
else
{
    bool resultFoundFlag = false;

    // Check if participants below in the rating have the same score.
    for (var i = K; i < N; i++)
    {
        if (scores[i] < scores[K - 1])
        {
            shortlistedParticipantsNumber = i;
            resultFoundFlag = true;
            break;
        }
    }

    // All remaining participants have the same score and can be shortlisted.
    if (!resultFoundFlag)
    {
        shortlistedParticipantsNumber = N;
    }
}

// Write the result.
Console.WriteLine(shortlistedParticipantsNumber);
