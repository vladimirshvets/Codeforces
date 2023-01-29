/* 
 * Task 467A
 * 
 * https://codeforces.com/problemset/problem/467/A 
 */

// Read the number of rooms.
int numberOfRooms = int.Parse(Console.ReadLine());

// Read and process the current and total room capacity.
int availableRooms = 0;
for (int i = 0; i < numberOfRooms; i++)
{
    string input = Console.ReadLine();
    string[] separatedInput = input.Split(' ');
    int currentCapacity = int.Parse(separatedInput[0]);
    int totalCapacity = int.Parse(separatedInput[1]);

    if (totalCapacity - currentCapacity > 1)
    {
        availableRooms++;
    }
}

// Write the result.
Console.WriteLine(availableRooms);
