/* 
 * Task 136A
 * 
 * https://codeforces.com/problemset/problem/136/A
 */

// Read the number of friends invited to the party and the order of gifts.
int numberOfParticipants = int.Parse(Console.ReadLine());
string input = Console.ReadLine();
string[] separatedInput = input.Split(' ');
int[] giftTakers = Array.ConvertAll(separatedInput, v => int.Parse(v));

// Swap givers and takers.
var giftGivers = new Dictionary<int, int>();
for (int i = 1; i <= numberOfParticipants; i++)
{
    giftGivers.Add(giftTakers[i - 1], i);
}

// Write the result.
for (int i = 1; i <= numberOfParticipants; i++)
{
    Console.Write($"{giftGivers[i]} ");
}
