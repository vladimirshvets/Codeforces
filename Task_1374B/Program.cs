/* 
 * Task 1374B
 * 
 * https://codeforces.com/problemset/problem/1374/B
 */

int numberOfTests = int.Parse(Console.ReadLine());

for (int i = 0; i < numberOfTests; i++)
{
    int value = int.Parse(Console.ReadLine());

    int numberOfTwo = 0;
    int numberOfThree = 0;
    while (value % 3 == 0)
    {
        value /= 3;
        numberOfThree++;
    }
    while (value % 2 == 0)
    {
        value /= 2;
        numberOfTwo++;
    }

    if (value == 1)
    {
        if (numberOfTwo <= numberOfThree)
        {
            Console.WriteLine(numberOfThree - numberOfTwo + numberOfThree);
            continue;
        }
    }
    
    Console.WriteLine(-1);
}
