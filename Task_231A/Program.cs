/* 
 * Task 231A
 * 
 * https://codeforces.com/problemset/problem/231/A 
 */


// Read the number of tasks - an integer value in range [1..1000].
var N = int.Parse(Console.ReadLine());

// Counter of tasks to be implemented.
int numberOfTasksToImplement = 0;

// Handle guys' opinion for each task.
for (var i = 0; i < N; i++)
{
    // Read three values as a single string, split them
    // and convert to integer values.
    string opinionInput = Console.ReadLine();
    string[] opinionInputSeparatedValues = opinionInput.Split(' ');
    int[] opinions = Array.ConvertAll(opinionInputSeparatedValues, int.Parse);

    // Increment counter if at least two guys have a solution
    // for particular task.
    if (opinions.Sum() >= 2)
    {
        numberOfTasksToImplement++;
    }
}

// Write the result.
Console.WriteLine(numberOfTasksToImplement);
