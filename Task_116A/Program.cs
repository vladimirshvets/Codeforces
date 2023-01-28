/* 
 * Task 116A
 * 
 * https://codeforces.com/problemset/problem/116/A 
 */

// Minimum number of passengers that the tram can carry.
int minTramCapacity = 0;
int currentNumberOfPassengers = 0;

// Read the number of tram stops.
int numberOfTramStops = int.Parse(Console.ReadLine());

// Process passengers activity on every tram stop.
for (int i = 0; i < numberOfTramStops; i++)
{
    // Read the number of passengers get on and off the tram.
    string input = Console.ReadLine();
    string[] separatedInput = input.Split(' ');
    int numberOfPassengersOut = int.Parse(separatedInput[0]);
    int numberOfPassengersIn = int.Parse(separatedInput[1]);

    // Increase minimum tram capacity if necessary.
    currentNumberOfPassengers -= numberOfPassengersOut;
    currentNumberOfPassengers += numberOfPassengersIn;
    if (currentNumberOfPassengers > minTramCapacity)
    {
        minTramCapacity = currentNumberOfPassengers;
    }    
}

// Write the result.
Console.WriteLine(minTramCapacity);
