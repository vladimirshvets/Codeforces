/* 
 * Task 1791G2
 * 
 * https://codeforces.com/problemset/problem/1791/G2
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

    // Item1 is a forward travel cost value.
    // Item2 is a backward travel cost value.
    List<Tuple<int, int>> travelCosts = new();

    for (int j = 0, k = numberOfTeleports - 1; j < numberOfTeleports; j++, k--)
    {
        // Calculate the travel costs as teleport costs plus
        // costs of the road to reach that teleport.
        int teleportCost = int.Parse(separatedInput[j]);
        int travelCostForward = teleportCost + j + 1;
        int travelCostBackward = teleportCost + k + 1;
        if (travelCostForward <= moneyOnHand ||
            travelCostBackward <= moneyOnHand)
        {
            travelCosts.Add(
                Tuple.Create(travelCostForward, travelCostBackward));
        }
    }

    int numberOfUsedTeleports = 0;
    while (travelCosts.Count > 0)
    {
        // ToDo: Determine which teleport is the best for usage.
        // Removal of the element with minimum cost is not optimal decision
        // in some cases.
        // Example: Input 2 14 / 7 5. Costs are F=(8 7), B=(9 6).
        var minCostForward = travelCosts.MinBy(c => c.Item1);
        var minCostBackward = travelCosts.MinBy(c => c.Item2);

        // The player have to start from 0 coordinate.
        if (numberOfUsedTeleports == 0 ||
            minCostForward.Item1 <= minCostBackward.Item2)
        {
            if (minCostForward.Item1 <= moneyOnHand)
            {
                numberOfUsedTeleports++;
                moneyOnHand -= minCostForward.Item1;
                travelCosts.Remove(minCostForward);
            }
            else
            {
                break;
            }
        }
        else
        {
            if (minCostBackward.Item2 <= moneyOnHand)
            {
                numberOfUsedTeleports++;
                moneyOnHand -= minCostBackward.Item2;
                travelCosts.Remove(minCostBackward);
            }
            else
            {
                break;
            }
        }
    }

    // Write the result.
    Console.WriteLine("---" + numberOfUsedTeleports);
}
