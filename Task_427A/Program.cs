/* 
 * Task 427A
 * 
 * https://codeforces.com/problemset/problem/427/A
 */

// Read the number of events and the events themselves.
int numberOfEvents = int.Parse(Console.ReadLine());
string input = Console.ReadLine();
string[] separatedInput = input.Split(' ');
int[] events = Array.ConvertAll(separatedInput, e => int.Parse(e));

int numberOfFreeCops = 0;
int numberOfUnsolvedCrimes = 0;
for (int i = 0; i < numberOfEvents; i++)
{
    // Hiring new cops.
    if (events[i] > 0)
    {
        numberOfFreeCops += events[i];
    }
    else
    {
        // No free cops to solve crime.
        if (numberOfFreeCops == 0)
        {
            numberOfUnsolvedCrimes++;
        }
        // Make one of the cops busy.
        else
        {
            numberOfFreeCops--;
        }
    }    
}

// Write the result.
Console.WriteLine(numberOfUnsolvedCrimes);
