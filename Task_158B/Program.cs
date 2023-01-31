/* 
 * Task 158B
 * 
 * https://codeforces.com/problemset/problem/158/B
 */

// Read the total number of groups and their sizes.
int numberOfGroups = int.Parse(Console.ReadLine());
string input = Console.ReadLine();
string[] separatedInput = input.Split(' ');
int[] groupSizes = Array.ConvertAll(separatedInput, s => int.Parse(s));

// Calculate the number of groups of each size.
var groups = new int[5];
for (int i = 0; i < numberOfGroups; i++)
{
    groups[groupSizes[i]]++;
}

int numberOfTaxiCars = 0;
// Step 1: Groups of four need a whole taxi car.
numberOfTaxiCars += groups[4];

// Step 2: Groups of three can only be combined with groups of one.
int numberOfCombinedGroupsOfThreeAndOne = Math.Min(groups[1], groups[3]);
numberOfTaxiCars += numberOfCombinedGroupsOfThreeAndOne;
groups[1] -= numberOfCombinedGroupsOfThreeAndOne;
groups[3] -= numberOfCombinedGroupsOfThreeAndOne;

// Step 3: If there are any other groups of three, they need a whole taxi car.
if (groups[3] > 0)
{
    numberOfTaxiCars += groups[3];
}

// Step 4: Groups of two can be combined as 2+2.
numberOfTaxiCars += groups[2] * 2 / 4;
groups[2] %= 2;

// Step 5: Groups of one can be combined as 1+1+1+1.
numberOfTaxiCars += groups[1] / 4;
groups[1] %= 4;

// Step 6: By this moment there can be up to one group of two and
// up to 3 groups of one.
switch (groups[1] + 2 * groups[2])
{
    case > 4:
        numberOfTaxiCars += 2;
        break;

    case > 0:
        numberOfTaxiCars++;
        break;
}

// Write the result.
Console.WriteLine(numberOfTaxiCars);
