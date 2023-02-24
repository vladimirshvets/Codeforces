/* 
 * Task 489B
 * 
 * https://codeforces.com/problemset/problem/489/B
 */

// Read numbers of boys/girls and their skills.
byte numberOfBoys = byte.Parse(Console.ReadLine());
byte[] boys =
    Array.ConvertAll(Console.ReadLine().Split(' '), v => byte.Parse(v));
byte numberOfGirls = byte.Parse(Console.ReadLine());
byte[] girls =
    Array.ConvertAll(Console.ReadLine().Split(' '), v => byte.Parse(v));

// Sort the skills and search for boy-girl match.
Array.Sort(boys);
Array.Sort(girls);
byte numberOfPairs = 0;
for (byte i = 0; i < numberOfBoys; i++)
{
    for (byte j = 0; j < numberOfGirls; j++)
    {
        if (Math.Abs(boys[i] - girls[j]) <= 1)
        {
            // Mark girl as busy and move to next boy.
            numberOfPairs++;
            girls[j] = byte.MaxValue;
            break;
        }
    }
}

// Write the result.
Console.WriteLine(numberOfPairs);
