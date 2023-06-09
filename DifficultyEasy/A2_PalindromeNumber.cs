using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetC_exercise.DifficultyEasy
{
    internal class A2_PalindromeNumber
    {
        public static void mMain()
        {
            try
            {
                Console.WriteLine("\nInsert an integer to print if is a Palindrome Number: ");
                int numX = Convert.ToInt32(Console.ReadLine());
                Console.Write("\n{0} is a Palindrome: ", numX);
                Console.Write(IsPalindrome(numX));
                Console.WriteLine();
            }catch (Exception ex)
            {
                Console.WriteLine("please insert an integer");
            }
        }

        public static bool IsPalindrome(int x)
        {
            string array = x.ToString();    
            string result = string.Empty;

            for (int i = array.Length-1; i >= 0; i--)
            {
                result += array[i];
            }
            return result == array;
        }
    }
}
