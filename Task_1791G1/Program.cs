/* 
 * Task 1791G1
 * 
 * https://codeforces.com/problemset/problem/1791/G1
 */

// Read the number of tests.
int numberOfTests = int.Parse(Console.ReadLine());

for (int i = 0; i < numberOfTests; i++)
{
    // Read the number of teleports and the amount of money on hand.
    string input = Console.ReadLine();
    string[] separatedInput = input.Split(' ');
    int numberOfTeleports = int.Parse(separatedInput[0]);
    int moneyOnHand = int.Parse(separatedInput[1]);
    input = Console.ReadLine();
    separatedInput = input.Split(' ');

    List<int> travelCosts = new();
    for (int j = 0; j < numberOfTeleports; j++)
    {
        // Calculate the travel costs as teleport costs plus
        // costs of the road to reach that teleport.
        int teleportCost = int.Parse(separatedInput[j]);
        if (teleportCost + j + 1 <= moneyOnHand)
        {
            travelCosts.Add(teleportCost + j + 1);
        }
    }
    travelCosts.Sort();

    int numberOfUsedTeleports = 0;
    foreach (int cost in travelCosts)
    {
        if (cost <= moneyOnHand)
        {
            numberOfUsedTeleports++;
            moneyOnHand -= cost;
        }
        else
        {
            break;
        }
    }

    // Write the result.
    Console.WriteLine(numberOfUsedTeleports);
}
    