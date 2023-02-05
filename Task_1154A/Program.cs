/* 
 * Task 1154A
 * 
 * https://codeforces.com/problemset/problem/1154/A
 */

// Read the values.
string input = Console.ReadLine();
string[] separatedInput = input.Split(' ');
int[] values = Array.ConvertAll(separatedInput, v => int.Parse(v));

// Get the maximum element as a summ and calculate the addends.
Array.Sort(values);
List<int> addends = new();
for (int i = 0; i < values.Length - 1; i++)
{
    addends.Add(values.Last() - values[i]);
}

// Write the result.
Console.WriteLine(string.Join(' ', addends));



