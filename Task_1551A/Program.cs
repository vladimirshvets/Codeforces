/* 
 * Task 1551A
 * 
 * https://codeforces.com/problemset/problem/1551/A
 */

int numberOfTests = int.Parse(Console.ReadLine());

for (int i = 0; i < numberOfTests; i++)
{
    int total = int.Parse(Console.ReadLine());

    int numberOfOnes = total / 3;
    switch (total % 3)
    {
        case 0:
            Console.WriteLine($"{numberOfOnes} {numberOfOnes}");
            break;

        case 1:
            Console.WriteLine($"{numberOfOnes + 1} {numberOfOnes}");
            break;

        case 2:
            Console.WriteLine($"{numberOfOnes} {numberOfOnes + 1}");
            break;
    }
}
