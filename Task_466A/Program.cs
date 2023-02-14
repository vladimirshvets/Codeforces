/* 
 * Task 466A
 * 
 * https://codeforces.com/problemset/problem/466/A
 */

// Read input data.
string[] input = Console.ReadLine().Split(' ');
int numberOfRides = int.Parse(input[0]);
int subscriptionSize = int.Parse(input[1]);
int rideCost = int.Parse(input[2]);
int subscriptionCost = int.Parse(input[3]);

// Search for minimum total.
int total = int.MaxValue;
for (int i = numberOfRides; i >= 0; i--)
{
    int numberOfSubscriptions = (numberOfRides - i) % subscriptionSize == 0
        ? (numberOfRides - i) / subscriptionSize
        : (numberOfRides - i) / subscriptionSize + 1;

    total = Math.Min(
        total,
        i * rideCost + numberOfSubscriptions * subscriptionCost);
}

// Write the result.
Console.WriteLine(total);
