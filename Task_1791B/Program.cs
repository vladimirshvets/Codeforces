/* 
 * Task 1791B
 * 
 * https://codeforces.com/problemset/problem/1791/B
 */

// Read the number of tests.
int numberOfTests = int.Parse(Console.ReadLine());

// For each test check if Alperen can pick up the sweet.
for (int i = 0; i < numberOfTests; i++)
{
    // Read the steps.
    int numberOfSteps = int.Parse(Console.ReadLine());
    string steps = Console.ReadLine();
    int coordinateX = 0;
    int coordinateY = 0;
    bool canPickUpSweet = false;

    for (int j = 0; j < steps.Length; j++)
    {
        // Make the step.
        switch (steps[j])
        {
            case 'U':
                coordinateY++;
                break;

            case 'D':
                coordinateY--;
                break;

            case 'L':
                coordinateX--;
                break;

            case 'R':
                coordinateX++;
                break;
        }

        // Check current coordinates.
        if (coordinateX == 1 && coordinateY == 1)
        {
            canPickUpSweet = true;
            break;
        }
    }

    // Write the result.
    Console.WriteLine(canPickUpSweet ? "YES" : "NO");
}
