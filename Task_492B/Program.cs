/* 
 * Task 492B
 * 
 * https://codeforces.com/problemset/problem/492/B
 */

// Read the number of lights, street length and coordinates of each light.
string input = Console.ReadLine();
string[] separatedInput = input.Split(' ');
int numberOfLights = int.Parse(separatedInput[0]);
int streetLength = int.Parse(separatedInput[1]);
input = Console.ReadLine();
separatedInput = input.Split(' ');
int[] lightCoordinates = Array.ConvertAll(separatedInput, c => int.Parse(c));

// Calculate the minimum radius of lights.
double minLightRadius = 0;
Array.Sort(lightCoordinates);

// Check the distances between each pair of lights standing side by side.
for (int i = 0; i < numberOfLights - 1; i++)
{
    double nearLightsDistance =
        (double)(lightCoordinates[i + 1] - lightCoordinates[i]);
    if (nearLightsDistance / 2 > minLightRadius)
    {
        minLightRadius = nearLightsDistance / 2;
    }
}

// Check the distance between the start of the street and the first light.
if (lightCoordinates[0] > minLightRadius)
{
    minLightRadius = lightCoordinates[0];
}
// Check the distance between the end of the street and the last light.
if (streetLength - lightCoordinates[numberOfLights - 1] > minLightRadius)
{
    minLightRadius = streetLength - lightCoordinates[numberOfLights - 1];
}

// Write the result.
Console.WriteLine(minLightRadius);
