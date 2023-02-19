/* 
 * Task 43A
 * 
 * https://codeforces.com/problemset/problem/43/A
 */

// Read the number of goals and linked team names.
int numberOfGoals = int.Parse(Console.ReadLine());
string[] goals = new string[numberOfGoals];
for (int i = 0; i < numberOfGoals; i++)
{
    goals[i] = Console.ReadLine();
}

// Group goals by team names and count them.
var result = from goal in goals
             group goal by goal into team
             orderby team.Count() descending
             select new { Name = team.Key, Count = team.Count() };


// Write the result.
Console.WriteLine(result.First().Name);
