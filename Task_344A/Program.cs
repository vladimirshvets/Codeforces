/* 
 * Task 344A
 * 
 * https://codeforces.com/problemset/problem/344/A
 */

// Read the number of magnets.
int numberOfMagnets = int.Parse(Console.ReadLine());

// Read the current state of magnet and compare with previous one.
int numberOfIslands = 0;
string previousMagnetState = string.Empty;

for (int i = 0; i < numberOfMagnets; i++)
{
    string currentMagnetState = Console.ReadLine();
    if (currentMagnetState != previousMagnetState)
    {
        numberOfIslands++;
        previousMagnetState = currentMagnetState;
    }
}

// Write the result.
Console.WriteLine(numberOfIslands);
