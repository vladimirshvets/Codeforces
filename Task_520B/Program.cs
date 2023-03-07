/* 
 * Task 520B
 * 
 * https://codeforces.com/problemset/problem/520/B
 */

string[] input = Console.ReadLine().Split(' ');
int source = int.Parse(input[0]);
int destination = int.Parse(input[1]);

int numberOfActions = 0;
while (destination != source)
{
    if (source > destination)
    {
        destination++;
    }
    else
    {
        if (destination % 2 == 0)
        {
            destination /= 2;
        }
        else
        {
            destination++;
        }
    }
    numberOfActions++;
}

Console.WriteLine(numberOfActions);
