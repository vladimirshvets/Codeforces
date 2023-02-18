/* 
 * Task 1433A
 * 
 * https://codeforces.com/problemset/problem/1433/A
 */

// Read the number of tests.
byte numberOfTests = byte.Parse(Console.ReadLine());

// Get the boring numbers.
Dictionary<int, int> boringNumbers = ProduceBoringNumbers();

for (byte i = 0; i < numberOfTests; i++)
{
    // Read the number of last disturbed apartment.
    int apartment = int.Parse(Console.ReadLine());

    Console.WriteLine(boringNumbers.GetValueOrDefault(apartment));
}

// Produce the boring numbers together with digits counter.
Dictionary<int, int> ProduceBoringNumbers()
{
    Dictionary<int, int> boringNumbers = new(36);
    for (byte i = 1; i <= 9; i++)
    {
        for (byte j = 1; j <= 4; j++)
        {
            int digitsCount = 10 * (i - 1);
            int number = 0;
            for (byte k = 1; k <= j; k++)
            {
                number = number * 10 + i;
                digitsCount += k;
            }

            boringNumbers.Add(number, digitsCount);
        }
    }

    return boringNumbers;
}
