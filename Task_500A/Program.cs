/* 
 * Task 500A
 * 
 * https://codeforces.com/problemset/problem/500/A
 */

// Read the number of cells and the destination cell index.
string[] input = Console.ReadLine().Split(' ');
int numberOfCells = int.Parse(input[0]);
int destination = int.Parse(input[1]) - 1;

// Read the index offsets that are provided by portals.
int[] portalOffsets =
    Array.ConvertAll(Console.ReadLine().Split(' '), v => int.Parse(v));

// Find the result using the depth search and write it.
Console.WriteLine(CanReachCell(destination) ? "YES" : "NO");

// A local function that searches for any route
// from the cell (0) to the specified cell.
bool CanReachCell(int destination)
{
    if (destination == 0)
    {
        return true;
    }

    bool routeExists = false;
    for (int i = 0; i < numberOfCells - 1; i++)
    {
        if (i + portalOffsets[i] == destination)
        {
            routeExists = CanReachCell(i);
            if (routeExists)
            {
                return true;
            }
        }
    }

    return false;
}
