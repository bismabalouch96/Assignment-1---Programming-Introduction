using System;

namespace Assignment_1___Programming_Introduction
{

        class Program
        {
            /* <summary>
             * /// Input: moves = "UD"
             * /// Output: true
             * /// Explanation: The robot moves up once, and then down once.
             * All moves have the same magnitude, so it ended up at the origin where it started. 
             * Therefore, we return true.
             * </summary>
             * <retunrs>
             * true/False
             * </returns>
              comment
             */



            public bool JudgeCircle(string moves)
            {
                try

                {
                    int x = 0;
                    int y = 0;

                    //For each move, add or subtract to (x, y) coords
                    for (int i = 0; i < moves.Length; i++)
                    {
                        if (moves[i] == 'U')

                        {
                            y++;
                        }
                        else if (moves[i] == 'D')
                        {
                            y--;
                        }
                        else if (moves[i] == 'L')
                        {
                            x--;
                        }
                        else if (moves[i] == 'R')
                        {
                            x++;
                        }
                    }

                    //If coords equal to (0, 0), returns to original position
                    if (x == y && x == 0)
                    {
                        return true;
                    }

                    return false;
                }
                catch (Exception)
                {
                    throw;
                }
            }


            /*  <summary>
             *  A pangram is a sentence where every letter of the English alphabet appears at least once.
             *  Given a string sentence containing only lowercase English letters, returntrue if sentence is a pangram, or false otherwise.
             *  Example 1:Input: sentence = "thequickbrownfoxjumpsoverthelazydog"
             *  Output: trueExplanation: sentence contains at least one of every letter of the English alphabet.
             *  </summary>
             *  </returns>
             *  true/false
             *  </returns>
             *  Note: Use of String function (Contains) and hasmap is not allowed, think of other ways how you could the numbers be represented     
             *  
             */

            public bool CheckIfPangram(string sentence)
            {
                try
                {

                    string alphabets = "abcdefghijklmnopqrstuvwxyz";
                    int count = 0;

                    foreach (char c in alphabets)

                    {

                        foreach (char l in sentence.ToLower())

                        {

                            if (c == l)

                            {

                                count++;

                                break;

                            }

                        }

                    }

                    if (count == 26)

                        return true;


                    return false;

                }

                catch (Exception)
                {
                    throw;
                }
            }

            /*<summary>
             * Given an array of integers nums 
             * A pair (i,j) is called good if nums[i] == nums[j] and i < j.
             * Return the number of good pairs.
             * Example:Input: nums = [1,2,3,1,1,3]
             * Output: 4
             * Explanation: There are 4 good pairs (0,3), (0,4), (3,4), (2,5) 0-indexed.  
             * return type  : int
             * </summary>
             * <returns>
             * int 
             * </returns>
             */

            public int NumIdenticalPairs(int[] nums)
            {
                try
                {


                    int sum = 0;

                    for (int i = 0; i < nums.Length; i++)
                    {
                        for (int j = i + 1; j < nums.Length; j++)
                        {
                            if (nums[i] == nums[j])
                            {
                                sum++;
                            }
                        }
                    }
                    return sum;
                }
                catch (Exception)
                {
                    throw;
                }
            }



            /*
             * <summary>
             * Given an array of integers nums, 
             * calculate the pivot index of this array.
             * The pivot index is the index where the sum of all the numbers strictly to the left of  the index is equal to the sum of all the numbers strictly to the index's right.
             * If the index is on the left edge of the array, then the left sum is 0 because there are no elements to the left. 
             * This also applies to the right edge of the array.Return the leftmost pivot index. 
             * If no such index exists, return -1.
             * Example 1:Input: nums = [1,7,3,6,5,6]
             * Output : 3
             * Explanation:The pivot index is 3.
             * Left sum = nums[0] + nums[1] + nums[2] = 1 + 7 + 3 = 11
             * Right sum = nums[4] + nums[5] = 5 + 6 = 11        
             * /// </summary>        
             * /// <param name="nums">
             * </param>        
             * /// <returns>
             * Number the index in the array
             * </returns>    
             */

            public int PivotIndex(int[] nums)
            {
                try
                {


                    int[] leftSums = new int[nums.Length];

                    int[] rightSums = new int[nums.Length];

                    for (int i = 1; i < nums.Length; i++)

                    {

                        leftSums[i] = nums[i - 1] + leftSums[i - 1];

                        rightSums[nums.Length - i - 1] = nums[nums.Length - i] + rightSums[nums.Length - i];

                    }


                    for (int i = 0; i < nums.Length; i++)

                        if (leftSums[i] == rightSums[i])

                            return i;


                    return -1;

                }
                catch (Exception e)
                {
                    Console.WriteLine("An error occurred:" + e.Message);
                    throw;
                }
            }

            /*        
             *<summary> 
             *You are given two strings word1 and word2. 
             *Merge the strings by adding letters in alternating order, starting with word1. 
             *If a string is longer than the other, append the additional letters onto the end of the merged string.
             *Example 1
             *Input: word1 = "abc", word2 = "pqr"/// 
             *Output: "apbqcr"/// 
             *Explanation: The merged string will be merged as so:
             */// word1:  a   b   c///
               // word2:    p   q   r///
               // merged: a p b q c r///
               // </summary>       
               // <param name="word1">
               // </param>
               // <param name="word2">
               // </param>       
               // <returns>
               // return the merged string
               // </returns>*/

            public string MergeAlternately(string word1, string word2)

            {
                try
                {

                    string merge = "";


                    int x = 0;

                    int y = 0;

                    int z = word1.Length + word2.Length;

                    for (int i = 0; i < z; ++i)
                    {

                        if (x != word1.Length && i % 2 == 0 || y == word2.Length)

                            merge += word1[x++];

                        else

                            merge += word2[y++];

                    }

                    return merge;

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    throw;
                }
            }

            /*<summary>
             *A sentence sentence is given, composed of words separated by spaces. 
             *Each word consists of lowercase and uppercase letters only.
             *We would like to convert the sentence to "Goat Latin" (a made-up language similar to Pig Latin.)
             *The rules of Goat Latin are as follows: 
             *1)If a word begins with a vowel (a, e, i, o, or u), append "ma" to the end of the word.
             *For example, the word 'apple' becomes 'applema'.
             *2)If a word begins with a consonant (i.e. not a vowel), remove the first letter and append it to the end, then add "ma".
             *For example, the word "goat" becomes "oatgma".
             *3)Add one letter 'a' to the end of each word per its word index in the sentence, starting with 1.
             *For example, the first word gets "a" added to the end, the second word gets "aa" added to the end and so on.
             *Hint : think of a string function to divide the sentence on white spaces    
             */// </summary>    
               // <param name="sentence"></param>    
               // <returns>
               // string
               // </returns>
               //*/ 


            public string ToGoatLatin(string sentence)
            {
                try

                {
                    string result = "";
                    int num_words = 0;
                    string vowels = "aeiouAEIOU";
                    string consonant = "bcdfghiklmnjpqrstvwxyzBCDFGHIKLMNPJQRSTVWXYZ";
                    string temp = "";

                    int i = 0;

                    while (i < sentence.Length)
                    {
                        while (i < sentence.Length && sentence[i] != ' ')
                        {
                            temp += sentence[i];
                            i++;
                        }
                        num_words++;
                        i++;
                        // if first letter is a vowel
                        if (vowels.IndexOf(temp[0]) != -1)
                        {
                            temp += "ma";
                        }
                        // if first letter is a consonant
                        else if (consonant.IndexOf(temp[0]) != -1)
                        {
                            char firstLetter = temp[0];
                            temp = temp.Substring(1);
                            temp += firstLetter + "ma";
                        }
                        // append appropriate number of a's to the end
                        for (int j = 0; j < num_words; j++)
                        {
                            temp += 'a';
                        }
                        // when we append the first word to the results, we append it without a space
                        if (num_words == 1)
                        {
                            result += temp;
                        }
                        // every other word we append with a space to keep sentence structure 
                        else
                        {
                            result += ' ' + temp;
                        }
                        // reset temp
                        temp = "";
                    }
                    return result;

                }
                catch (Exception)
                {
                    throw;
                }




                static void Main(string[] args)
                {

                    Program myprog = new Program();

                    //Question 1
                    Console.WriteLine("Q1 : Enter the Moves of Robot:");
                    string moves = Console.ReadLine();
                    bool pos = myprog.JudgeCircle(moves);
                    if (pos)
                    {
                        Console.WriteLine("The Robot return’s to initial Position (0,0)");
                    }
                    else
                    {
                        Console.WriteLine("The Robot doesn’t return to the Initial Postion (0,0)");
                    }

                    //Question 2:
                    Console.WriteLine(" Q2 : Enter the string to check for pangram:");
                    string s = Console.ReadLine();
                    bool flag = myprog.CheckIfPangram(s);
                    if (flag)
                    {
                        Console.WriteLine("Yes, the given string is a pangram");
                    }
                    else
                    {
                        Console.WriteLine("No, the given string is not a pangram");
                    }
                    Console.WriteLine();

                    //Question 3:

                    int[] arr = { 1, 1, 1, 1 };
                    int gp = myprog.NumIdenticalPairs(arr);
                    Console.WriteLine("Q3:");
                    Console.WriteLine("The number of IdenticalPairs in the array are {0}:", gp);


                    //Question 4:
                    int[] arr1 = { 1, 7, 3, 6, 5, 6 };
                    Console.WriteLine("Q4:");
                    int pivot = myprog.PivotIndex(arr1);
                    if (pivot > 0)
                    {
                        Console.WriteLine("The Pivot index for the given array is {0}", pivot);
                    }
                    else
                    {
                        Console.WriteLine("The given array has no Pivot index");
                    }

                    //Question 5:
                    Console.WriteLine("Q5:");
                    Console.WriteLine("Enter the First Word:");
                    String word1 = Console.ReadLine();
                    Console.WriteLine("Enter the Second Word:");
                    String word2 = Console.ReadLine();
                    String merged = myprog.MergeAlternately(word1, word2);
                    Console.WriteLine("The Merged Sentence fromed by both words is {0}", merged);


                    //Quesiton 6:
                    Console.WriteLine("Q6: Enter the sentence to convert:");
                    string sentence = Console.ReadLine();
                    string goatLatin = myprog.ToGoatLatin(sentence);
                    Console.WriteLine("Goat Latin for the Given Sentence is: {0}", goatLatin);
                    Console.WriteLine();
                }
            }
        }
    }
