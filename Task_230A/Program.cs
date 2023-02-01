/* 
 * Task 230A
 * 
 * https://codeforces.com/problemset/problem/230/A 
 */

// Read the number of dragons and initial value of power.
string input = Console.ReadLine();
string[] separatedInput = input.Split(' ');
int powerValue = int.Parse(separatedInput[0]);
int numberOfDragons = int.Parse(separatedInput[1]);

// Read the power of each dragon and the bonus in case of win.
var competitors = new List<KeyValuePair<int, int>>();
for (int i = 0; i < numberOfDragons; i++)
{
    input = Console.ReadLine();
    separatedInput = input.Split(' ');
    int dragonPower = int.Parse(separatedInput[0]);
    int winBonus = int.Parse(separatedInput[1]);
    competitors.Add(KeyValuePair.Create(dragonPower, winBonus));
}

// Fight with dragons one by one ordered by dragon power.
foreach (var competitor in competitors.OrderBy(c => c.Key))
{
    if (powerValue > competitor.Key)
    {
        // Enough power, hero wins the dragon.
        powerValue += competitor.Value;
    }
    else
    {
        // Not enough power, hero loses.
        powerValue = 0;
        break;
    }
}

// Write the result.
Console.WriteLine(powerValue > 0 ? "YES" : "NO");
