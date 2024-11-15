// https://leetcode.com/problems/remove-element/description/
namespace LeetCode.RemoveElement;

public class Solution
{
    public int RemoveElement(int[] nums, int val)
    {
        var k = 0;
        for (var i = 0; i < nums.Length - k; i++)
        {
            if (nums[i] == val)
            {
                Unshift(nums, i);
                i--;
                k++;
            }
        }

        return nums.Length - k;
    }

    private void Unshift(int[] nums, int from)
    {
        var first = nums[from];
        for (int i = from + 1; i < nums.Length; i++)
        {
            nums[i - 1] = nums[i];
        }

        nums[nums.Length - 1] = first;
    }
}
