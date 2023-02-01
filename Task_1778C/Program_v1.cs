///* 
// * Task 1778C
// * 
// * https://codeforces.com/problemset/problem/1778/C
// */

//// Read the number of tests.
//int numberOfTests = int.Parse(Console.ReadLine());
//for (int i = 0; i < numberOfTests; i++)
//{
//    // Read the word length and max size of multitude.
//    string input = Console.ReadLine();
//    string[] separatedInput = input.Split(' ');
//    int wordLength = int.Parse(separatedInput[0]);
//    int multitudeMaxSize = int.Parse(separatedInput[1]);
//    string sourceWord = Console.ReadLine();
//    string finalWord = Console.ReadLine();

//    int numberOfPairs = 0;
//    for (int j = 0; j < wordLength; j++)
//    {
//        for (int k = j; k < wordLength; k++)
//        {
//            string sourceSubword = sourceWord.Substring(j, k - j + 1);
//            string finalSubword = finalWord.Substring(j, k - j + 1);
//            var listOfCharsToChange = new List<char>();
//            for (int l = 0; l < sourceSubword.Length; l++)
//            {
//                if (!sourceSubword[l].Equals(finalSubword[l]))
//                {
//                    if (!listOfCharsToChange.Contains(sourceSubword[l]))
//                    {
//                        listOfCharsToChange.Add(sourceSubword[l]);
//                    }
//                    if (listOfCharsToChange.Count() > multitudeMaxSize)
//                    {
//                        break;
//                    }
//                }
//            }
//            if (listOfCharsToChange.Count() <= multitudeMaxSize)
//            {
//                numberOfPairs++;
//            }
//            else
//            {
//                // No need to another subwords of a bigger length.
//                break;
//            }
//        }
//    }

//    // Write the result for each test.
//    Console.WriteLine(numberOfPairs);
//}
