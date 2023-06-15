using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LeetC_exercise.DifficultyEasy
{
    internal class A3_RomanToInteger
    {
        public static void mMain()
        {
            try
            {
                Console.WriteLine("\nPlease insert Roman Numeral to convert into decimal:\n"); 
                string romanLetter = Console.ReadLine().ToUpper();
                Console.WriteLine(RomanToInt(romanLetter));
            }catch (Exception ex)
            {
                Console.WriteLine("\nPlease insert only Roman Numeral Letters!\n" + ex.Message);
            }

        }

        public static int RomanToInt(string romanL)
        {
            int sumResult = 0;
            Dictionary<char,int> mapRomanLetter = new Dictionary<char, int> { { 'I',1}, { 'V', 5}, { 'X', 10 }, {'L',50 }, { 'C', 100}, { 'D', 500 }, { 'M',1000} };
            romanL = romanL.Replace("IV", "IIII").Replace("IX", "VIIII").Replace("XL", "XXXX").Replace("XC", "LXXXX").Replace("CD", "CCCC").Replace("CM", "DCCCC");

            foreach(char romanChar in romanL)
            {
                sumResult += mapRomanLetter[romanChar];
            }
            return sumResult;
        }
    }
}
