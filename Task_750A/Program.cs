/* 
 * Task 750A
 * 
 * https://codeforces.com/problemset/problem/750/A
 */

internal class Program
{
    /// <summary>
    /// Duration of competition, in minutes.
    /// </summary>
    private static readonly int timeToNewYear = 240;

    /// <summary>
    /// Time to solve each task, in minutes.
    /// </summary>
    private static readonly int[] taskTimes =
        { 0, 5, 10, 15, 20, 25, 30, 35, 40, 45, 50 };


    private static void Main(string[] args)
    {
        // Read the number of tasks and time to get to the party.
        string input = Console.ReadLine();
        string[] separatedInput = input.Split(' ');
        int numberOfTasks = int.Parse(separatedInput[0]);
        int travelTime = int.Parse(separatedInput[1]);

        // Calculate the number of tasks that can be done.
        int timeForTasks = timeToNewYear - travelTime;
        int maxNumberOfTasks = 0;
        for (int i = 1; i <= numberOfTasks; i++)
        {
            if (timeForTasks >= taskTimes[i])
            {
                maxNumberOfTasks++;
                timeForTasks -= taskTimes[i];
            }
            else
            {
                break;
            }
        }

        // Write the result.
        Console.WriteLine(maxNumberOfTasks);
    }
}
