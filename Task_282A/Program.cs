/* 
 * Task 282A
 * 
 * https://codeforces.com/problemset/problem/282/A 
 */

// Read a number of operators - integer value in range [1..150].
string input = Console.ReadLine();
var numberOfOperators = int.Parse(input);

int xValue = 0;

for (var i = 0; i < numberOfOperators; i++)
{
    input = Console.ReadLine();
    // Since an operator can contain ("++" or "--") and "X" only,
    // validation is not required. It's enough to search for "+" or "-"
    // and update the value of X.
    if (input.Contains('+'))
    {
        xValue++;
    }
    else
    {
        xValue--;
    }
}

// Write the result.
Console.WriteLine(xValue);
