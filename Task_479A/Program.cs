/* 
 * Task 479A
 * 
 * https://codeforces.com/problemset/problem/479/A
 */

// Read the numbers.
int numberA = int.Parse(Console.ReadLine());
int numberB = int.Parse(Console.ReadLine());
int numberC = int.Parse(Console.ReadLine());

// Since there are only two operators and three operands,
// it's much faster to just hardcode all possible options.
int maxResult = 0;
maxResult = Math.Max(maxResult, numberA * numberB * numberC);
maxResult = Math.Max(maxResult, (numberA + numberB) * numberC);
maxResult = Math.Max(maxResult, numberA * (numberB + numberC));
maxResult = Math.Max(maxResult, numberA + numberB * numberC);
maxResult = Math.Max(maxResult, numberA * numberB + numberC);
maxResult = Math.Max(maxResult, numberA + numberB + numberC);

// Write the result.
Console.WriteLine(maxResult);