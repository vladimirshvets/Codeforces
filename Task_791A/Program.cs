/* 
 * Task 791A
 * 
 * https://codeforces.com/problemset/problem/791/A 
 */

// Read the weight values.
string input = Console.ReadLine();
string[] inputSeparatedValues = input.Split(' ');
int weightA = int.Parse(inputSeparatedValues[0]);
int weightB = int.Parse(inputSeparatedValues[1]);

// Calculate the number of years to reach the biggest weight.
int yearsToWin = 0;
while (weightA <= weightB)
{
    weightA *= 3;
    weightB *= 2;
    yearsToWin++;
}

// Write the result.
Console.WriteLine(yearsToWin);
