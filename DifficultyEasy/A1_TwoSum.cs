using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetC_exercise.DifficultyEasy
{
    internal class A1_TwoSum
    {
        public static void mMain()
        {   
            int[] nums = { 2, 3, 7, 5, 11,19, 15 };
            int target = 9;
            int[] resTS = TwoSumB(nums, target);

            Console.Write("[ ");
            foreach (int i in resTS)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine("]");
        }
        
        //First solution brute force
        public static int[] TwoSum(int[] nums, int target)
        {
            int[] result = { };
            for(int i=0; i< nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (i == j)
                    {
                        continue;
                    }else if (nums[i] + nums[j] == target)
                    {
                        result = result.Append(i).ToArray();
                    }
                }
            }
            return result;
        }
        //Second solution, using dictionary
        public static int[] TwoSumB(int[] nums, int target)
        {
            Dictionary<int, int> hashD = new Dictionary<int, int>();
            
            for (int i =0; i < nums.Length; i++) 
            { 
                int check = target - nums[i];
                if (hashD.ContainsKey(check))
                {
                    return new int[] { hashD[check], i };
                }
                else if (!hashD.ContainsKey(nums[i])) 
                {
                    hashD.Add(nums[i], i);
                }
            }
            return null;
        }
    }
}
