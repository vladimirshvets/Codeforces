/* 
 * Task 677A
 * 
 * https://codeforces.com/problemset/problem/677/A 
 */

// Read the number of friends and the height of the fence.
string input = Console.ReadLine();
string[] separatedInput = input.Split(' ');
int numberOfFriends = int.Parse(separatedInput[0]);
int fenceHeight = int.Parse(separatedInput[1]);

// Read each friend's height.
input = Console.ReadLine();
separatedInput = input.Split(' ');

// Calculate the line width.
int lineWidth = 0;
for (int i = 0; i < numberOfFriends; i++)
{
    int height = int.Parse(separatedInput[i]);
    // Each friend occupies at least one unit of width.
    lineWidth++;
    // The height of the guy can't be more than twice the height of the fence.
    if (height > fenceHeight)
    {
        lineWidth++;
    }
}

// Write the result.
Console.WriteLine(lineWidth);
