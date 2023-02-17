/* 
 * Task 381A
 * 
 * https://codeforces.com/problemset/problem/381/A
 */

// Read the number of cards and their values.
int numberOfCards = int.Parse(Console.ReadLine());
int[] cards =
    Array.ConvertAll(Console.ReadLine().Split(' '), v => int.Parse(v));

int[] scores = new int[2];
int i = 0;
int startPointer = 0;
int finishPointer = numberOfCards - 1;

// Move the pointers and increase the scores.
do
{
    scores[i] += cards[startPointer] > cards[finishPointer]
        ? cards[startPointer++]
        : cards[finishPointer--];
    i = (i + 1) % 2;
}
while (startPointer <= finishPointer);

// Write the result.
Console.WriteLine(string.Join(' ', scores));
