/* 
 * Task 263A
 * 
 * https://codeforces.com/problemset/problem/263/A 
 */

internal class Program
{
    private static void Main(string[] args)
    {
        int coordinateX = 0;
        int coordinateY = 0;

        // Search for "1" in a 5x5 matrix.
        for (int i = 0; i < 5; i++)
        {
            string input = Console.ReadLine();
            if (input.Contains('1'))
            {
                string[] inputSeparatedValues = input.Split(' ');
                coordinateX = i;
                coordinateY = Array.IndexOf(inputSeparatedValues, "1");
                // Skip further useless iterations.
                break;
            }
        }

        // The middle row/column in 5x5 matrix has an index of 3, however
        // I use 2 since I have coordinates counted from 0.
        int shiftX = GetShift(2, coordinateX);
        int shiftY = GetShift(2, coordinateY);
        int totalShift = shiftX + shiftY;

        // Write the result.
        Console.WriteLine(totalShift);
    }

    /// <summary>
    /// Returns the shift between two coordinates placed in random order.
    /// </summary>
    /// <param name="coordinateA">Coordinate A</param>
    /// <param name="coordinateB">Coordinate B</param>
    /// <returns>The distance between two coordinates.</returns>
    private static int GetShift(int coordinateA, int coordinateB)
    {
        return Math.Max(coordinateA, coordinateB) - Math.Min(coordinateA, coordinateB);
    }
}
