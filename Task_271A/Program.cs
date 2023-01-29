/* 
 * Task 271A
 * 
 * https://codeforces.com/problemset/problem/271/A 
 */

internal class Program
{
    private static void Main(string[] args)
    {
        // Read the year.
        int year = int.Parse(Console.ReadLine());

        // Search for the beautiful year.
        do
        {
            year++;
        }
        while (!IsYearBeautiful(year));

        // Write the result.
        Console.WriteLine(year);
    }

    /// <summary>
    /// Checks if all digits in the specified year are different.
    /// </summary>
    /// <param name="year">Year</param>
    /// <returns>true if the specified year is beautiful.</returns>
    private static bool IsYearBeautiful(int year)
    {
        int thousands = year / 1000;
        int hundreds = year / 100 % 10;
        int tens = year % 100 / 10;
        int ones = year % 100 % 10;

        return ((thousands != hundreds) &&
            (thousands != tens) &&
            (thousands != ones) &&
            (hundreds != tens) &&
            (hundreds != ones) &&
            (tens != ones));
    }
}
