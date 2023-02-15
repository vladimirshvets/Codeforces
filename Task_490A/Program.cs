/* 
 * Task 490A
 * 
 * https://codeforces.com/problemset/problem/490/A
 */

// Read the number of students and their tendencies.
int numberOfStudents = int.Parse(Console.ReadLine());
int[] tendencies =
    Array.ConvertAll(Console.ReadLine().Split(' '), v => int.Parse(v));

// Collect indexes based on tendency.
List<int> programmers = new();
List<int> mathematicians = new();
List<int> athletes = new();
for (int i = 0; i < numberOfStudents; i++)
{
    switch (tendencies[i])
    {
        case 1:
            programmers.Add(i);
            break;

        case 2:
            mathematicians.Add(i);
            break;

        case 3:
            athletes.Add(i);
            break;
    }
}

int numberOfTeams = programmers.Count();
numberOfTeams = Math.Min(numberOfTeams, mathematicians.Count());
numberOfTeams = Math.Min(numberOfTeams, athletes.Count());

// Write the result.
Console.WriteLine(numberOfTeams);
if (numberOfTeams > 0)
{
    for (int i = 0; i < numberOfTeams; i++)
    {
        Console.WriteLine(
            $"{programmers[i] + 1} {mathematicians[i] + 1} {athletes[i] + 1}");
    }
}
