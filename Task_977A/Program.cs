/* 
 * Task 977A
 * 
 * https://codeforces.com/problemset/problem/977/A 
 */

// Read the initial number and the number of operations.
string input = Console.ReadLine();
string[] separatedInput = input.Split(' ');
int initialNumber = int.Parse(separatedInput[0]);
int numberOfOperations = int.Parse(separatedInput[1]);

// Perform required operations.
int resultNumber = initialNumber;
for (int i = 0; i < numberOfOperations; i++)
{
    if (resultNumber % 10 > 0)
    {
        resultNumber--;
    }
    else
    {
        resultNumber /= 10;
    }
}

// Write the result.
Console.WriteLine(resultNumber);
