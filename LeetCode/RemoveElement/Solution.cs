// https://leetcode.com/problems/remove-element/description/
namespace LeetCode.RemoveElement;

public class Solution
{
    public int RemoveElement(int[] nums, int val)
    {
        var k = 0;
        var arr = new List<int>();
        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] == val)
            {
                k++;
            }
            else
            {
                arr.Add(nums[i]);
            }
        }

        Array.Copy(arr.ToArray(), nums, arr.Count);
        for (int i = arr.Count; i < nums.Length; i++)
        {
            nums[i] = 0;
        }
        return k;
    }
}
