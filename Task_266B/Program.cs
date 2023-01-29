/* 
 * Task 266B
 * 
 * https://codeforces.com/problemset/problem/266/B
 */

// Read the number of students and the moment of time.
string input = Console.ReadLine();
string[] separatedInput = input.Split(' ');
int numberOfStudents = int.Parse(separatedInput[0]);
int time = int.Parse(separatedInput[1]);

// Read the queue state.
input = Console.ReadLine();
char[] queue = input.ToCharArray();

// Modify the queue.
for (int i = 0; i < time; i++)
{
    bool isQueueChanged = false;
    int j = 0;
    while (j < numberOfStudents - 1)
    {
        // Equivalent to B < G.
        if (queue[j] < queue[j + 1])
        {
            queue[j] = 'G';
            queue[j + 1] = 'B';
            j += 2;
            isQueueChanged = true;
        }
        else
        {
            j++;
        }
    }
    // If the queue state hasn't changed by the end of the iteration,
    // no further iterations need to be performed.
    if (!isQueueChanged)
    {
        break;
    }
}

// Write the result.
Console.WriteLine(queue);
