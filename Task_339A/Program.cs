/* 
 * Task 339A
 * 
 * https://codeforces.com/problemset/problem/339/A 
 */

// Counters for the components of summ.
int numberOfComponentOne = 0,
    numberOfComponentTwo = 0,
    numberOfComponentThree = 0;

// Read the source strings.
string components = Console.ReadLine();
foreach (char c in components)
{
    switch (c)
    {
        case '1':
            numberOfComponentOne++;
            break;

        case '2':
            numberOfComponentTwo++;
            break;

        case '3':
            numberOfComponentThree++;
            break;
    }
}

// Push sorted components to a collection and concatenate them.
List<int> sortedComponentsList = new();
for (int i = 0; i < numberOfComponentOne; i++)
{
    sortedComponentsList.Add(1);
}
for (int i = 0; i < numberOfComponentTwo; i++)
{
    sortedComponentsList.Add(2);
}
for (int i = 0; i < numberOfComponentThree; i++)
{
    sortedComponentsList.Add(3);
}
string sortedComponents = string.Join('+', sortedComponentsList);

// Write the result.
Console.WriteLine(sortedComponents);
