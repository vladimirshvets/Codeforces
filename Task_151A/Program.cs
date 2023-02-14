/* 
 * Task 151A
 * 
 * https://codeforces.com/problemset/problem/151/A
 */

// Read input data.
int[] input =
    Array.ConvertAll(Console.ReadLine().Split(' '), v => int.Parse(v));

// Provide clear and readable names for values.
int numberOfFriends = input[0];
int numberOfBottles = input[1];
int bottleVolume = input[2];
int numberOfLimes = input[3];
int numberOfLimeSlices = input[4];
int saltWeight = input[5];
int sodaVolumePerPerson = input[6];
int saltWeightPerPerson = input[7];

// Calculate the number of toasts.
int maxSodaPortions = numberOfBottles * bottleVolume / sodaVolumePerPerson;
int maxLimePortions = numberOfLimes * numberOfLimeSlices;
int maxSaltPortions = saltWeight / saltWeightPerPerson;

int numberOfToasts =
    Math.Min(Math.Min(maxLimePortions, maxSaltPortions), maxSodaPortions) /
    numberOfFriends;

// Write the result.
Console.WriteLine(numberOfToasts);
