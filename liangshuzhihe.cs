using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace likou
{
    class liangshuzhihe
    {
       public static void start()
        {
            int[] nums = new int[] { 3, 2, 4 };
            int target = 6;
            var s = liangshuzhihe.TwoSum1(nums, target);
        }

        static int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                        return new int[] { i, j };
                }
            }
            return new int[] { 0, 0 };
        }
        static int[] TwoSum1(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums.Contains(target - nums[i]) && Array.IndexOf(nums, target - nums[i]) != i)
                {

                    return new int[] { i, Array.IndexOf(nums, target - nums[i]) };
                }
            }
            return new int[] { 0, 0 };
        }
        static int[] TwoSum2(int[] nums, int target)
        {
            Hashtable ht = new Hashtable();
            for (int i = 0; i < nums.Length; i++)
            {
                int s = target - nums[i];
                if (ht.ContainsValue(s))
                {
                    return new int[] { Array.IndexOf(nums, s), i };
                }
                ht.Add(i, nums[i]);
            }

            return new int[] { 0, 0 };
        }
    }
}
