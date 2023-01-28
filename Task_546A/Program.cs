/* 
 * Task 546A
 * 
 * https://codeforces.com/problemset/problem/546/A 
 */

// Read the input values.
string input = Console.ReadLine();
string[] inputSeparatedValues = input.Split(' ');
int firstBananaPrice = int.Parse(inputSeparatedValues[0]);
int cashOnHand = int.Parse(inputSeparatedValues[1]);
int desiredQtyOfBananas = int.Parse(inputSeparatedValues[2]);

// Calculate missing amount.
// Take into account that there may be cases when there is enough money on hand.
int priceMultiplier = (1 + desiredQtyOfBananas) * desiredQtyOfBananas / 2;
int totalAmount = priceMultiplier * firstBananaPrice;
int missingAmount = Math.Max(0, totalAmount - cashOnHand);

// Write the result.
Console.WriteLine(missingAmount);
