namespace Algorithms.Two_Sum___1;

/*
   Given an array of integers nums and an integer target,
   return indices of the two numbers such that they add up to target.
   You may assume that each input would have exactly one solution, and you may not use the same element twice.
   You can return the answer in any order.
*/

public class TwoSumSolution
{
    public int[] TwoSum(int[] nums, int target)
    {
        int[] result = new int[2];
        int maxIndex = nums.Length;

        for (int i = 0; i < maxIndex; i++)
        {
            for (int k = 1; k < maxIndex; k++)
            {
                if (i == k) continue;

                if (nums[i] + nums[k] == target)
                {
                    result[0] = i;
                    result[1] = k;
                    return result;
                }
            }
        }

        return result;
    }
}