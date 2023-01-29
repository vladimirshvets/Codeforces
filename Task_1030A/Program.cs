/* 
 * Task 1030A
 * 
 * https://codeforces.com/problemset/problem/1030/A
 */

// Read the number of people and their opinions.
int numberOfOpinions = int.Parse(Console.ReadLine());
string input = Console.ReadLine();
string[] opinions = input.Split(' ');

bool isTaskEasy = true;

for (int i = 0; i < numberOfOpinions; i++)
{
    if (opinions[i] == "1")
    {
        isTaskEasy = false;
        break;
    }
}

Console.WriteLine(isTaskEasy ? "EASY" : "HARD");