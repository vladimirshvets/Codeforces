/* 
 * Task 1560A
 * 
 * https://codeforces.com/problemset/problem/1560/A
 */

// Produce the described sequence.
const int MAX_INDEX = 1000;
int[] sequence = new int[MAX_INDEX + 1];
int i = 1;
int value = 0;
while (i <= MAX_INDEX)
{
    do
    {
        value++;
    }
    while (value % 3 == 0 || value % 10 == 3);
    sequence[i++] = value;
}

// Read the number of tests and the tests themselves.
int numberOfTests = int.Parse(Console.ReadLine());
for (int j = 0; j < numberOfTests; j++)
{
    int index = int.Parse(Console.ReadLine());

    // Write the result.
    Console.WriteLine(sequence[index]);
}
