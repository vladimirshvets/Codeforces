/* 
 * Task 617A
 * 
 * https://codeforces.com/problemset/problem/617/A 
 */

// Read the distance to the friend's house.
int distance = int.Parse(Console.ReadLine());

// Minimum nuber of steps to reach the house.
int minNumberOfSteps;

// Since any step length up to 5 is available,
// we can use the biggest step length.
switch (distance % 5)
{
    case > 0:
        minNumberOfSteps = distance / 5 + 1;
        break;

    default:
        minNumberOfSteps = distance / 5;
        break;
}

// Write the result.
Console.WriteLine(minNumberOfSteps);
