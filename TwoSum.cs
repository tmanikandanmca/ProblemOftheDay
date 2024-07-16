// Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

// You may assume that each input would have exactly one solution, and you may not use the same element twice.

// You can return the answer in any order.



// Example 1:

// Input: nums = [2,7,11,15], target = 9
// Output: [0,1]
// Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
// Example 2:

// Input: nums = [3,2,4], target = 6
// Output: [1,2]
// Example 3:

// Input: nums = [3,3], target = 6
// Output: [0,1]

//call this one in prohram.cs
// int[]
//         reponses = TwoSum.CalCulateTwoSum([3, 2, 4], 6);
//         reponses = TwoSum.CalCulateTwoSumV1([3, 2, 4], 6);
//         reponses = TwoSum.CalCulateTwoSumV2([3, 2, 4], 6);

using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

public static class TwoSum
{


    public static int[] CalCulateTwoSum(int[] nums, int target)
    {
        int[] res = new int[2];
        for (int i = 0; i <= nums.Length - 1; i++)
        {
            for (int j = i + 1; j <= nums.Length - 1; j++)
            {
                if (target == (nums[i] + nums[j]))
                {
                    res[0] = i;
                    res[1] = j;
                    break;
                }
            }
        }
        return res;
    }



    public static int[] CalCulateTwoSumV1(int[] nums, int target)
    {
        Dictionary<int, int> map = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            map[nums[i]] = i;
        }

        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];
            if (map.ContainsKey(complement) && map[complement] != i)
            {
                return new int[] { i, map[complement] };
            }
        }

        return null;
    }


    public static int[] CalCulateTwoSumV2(int[] nums, int target)
    {
        Dictionary<int, int> map = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];
            if (map.ContainsKey(complement))
            {
                return new int[] { map[complement], i };
            }

            map[nums[i]] = i;
        }

        return null;
    }
}