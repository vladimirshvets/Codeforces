/* 
 * Task 520B
 * 
 * https://codeforces.com/problemset/problem/520/B
 */

string[] input = Console.ReadLine().Split(' ');
int source = int.Parse(input[0]);
int destination = int.Parse(input[1]);

int numberOfActions = 0;
while (destination > source)
{
    int rest = destination % 2;
    //if (< destination - source)
    //{
    //    destination /= 2;
    //    numberOfActions += 1 + rest;
    //}
}