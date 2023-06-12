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
                Console.Write(IsPalindromeA(numX));
                Console.WriteLine();
            }catch (Exception ex)
            {
                Console.WriteLine("please insert an integer {0}", ex);
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
        // this solution is using arithmetic calculation to reveres the intinger input
        public static bool IsPalindromeA(int x)
        {
            if (x < 0) { return false; }

            int n = 0; // variable for arithmaetic calculation
            int temp = x; // variable to performe the while loop calculation for reversing the "int x"
            while (temp > 0)
            {
                Console.WriteLine("\n{0} = {1} * 10 + {2} % 10", n, n, temp);
                //this formula consists of reversing the intinger input using modulus by returning the division remainder
                //n = 0; temp = 1234;
                //ex: n = 0 * 10 + 1234 % 10  => n = 4
                //because modul 1234 % 10 = 123.4 and the module return the division remainder which is 4
                n = n * 10 + temp % 10; 
                Console.WriteLine("temp => {0} % 10 = {1}", temp, temp %10);
                Console.WriteLine("n = {0}", n);
                Console.WriteLine("temp = {0}", temp);
                //the temp variable being integer will return all the time a whole number when is divided
                //ex: temp = 1234 / 10 => temp = 123 because the division with 10 resulting in 123.4 
                // and using integer will return a whole number for division operation
                temp = temp / 10;
                Console.WriteLine("temp / 10 = {0}", temp);
                Console.WriteLine();
            }
            return x == n;
        }
    }
}
