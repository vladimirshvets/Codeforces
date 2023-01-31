/* 
 * Task 25A
 * 
 * https://codeforces.com/problemset/problem/25/A
 */

// Read the sequence of numbers and its length.
using System;

int sequenceLength = int.Parse(Console.ReadLine());
string input = Console.ReadLine();
string[] separatedInput = input.Split(' ');
List<int> numbers =
    Array.ConvertAll(separatedInput, n => int.Parse(n)).ToList();

// Check first three numbers. If the sequence is even,
// no more than one number of three can be odd.
bool isExtraNumberOdd = (numbers[0] % 2 + numbers[1] % 2 + numbers[2] % 2) <= 1;

int indexOfExtraNumber;
if (isExtraNumberOdd)
{
    indexOfExtraNumber = numbers.FindIndex(n => n % 2 == 1);
}
else
{
    indexOfExtraNumber = numbers.FindIndex(n => n % 2 == 0);
}

// Write the result.
Console.WriteLine(indexOfExtraNumber + 1);
