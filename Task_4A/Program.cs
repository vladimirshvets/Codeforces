/* 
 * Task 4A
 * 
 * https://codeforces.com/problemset/problem/4/A 
 */


// Read a watermelon weight - integer value in range [1..100].
string weightInput = Console.ReadLine();
var weight = int.Parse(weightInput);

// Write whether the weight can be the sum of two even numbers.
if ((weight % 2 == 0) && (weight != 2))
{
    Console.WriteLine("YES");
}
else
{
    Console.WriteLine("NO");
}
