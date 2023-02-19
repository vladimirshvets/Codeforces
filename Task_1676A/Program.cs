/* 
 * Task 1676A
 * 
 * https://codeforces.com/problemset/problem/1676/A
 */

// Read the number of tests.
int numberOfTests = int.Parse(Console.ReadLine());

for (int i = 0; i < numberOfTests; i++)
{
    string ticket = Console.ReadLine();
    Console.WriteLine(
        SumOfDigits(ticket.Substring(0, 3)) == SumOfDigits(ticket.Substring(3))
        ? "YES"
        : "NO");

}

// Calculate the sum of digits in digit-only string.
int SumOfDigits(string s)
{
    int sum = 0;
    Array.ForEach(s.ToArray(), x => sum += (int)x - 48);
    return sum;
}
