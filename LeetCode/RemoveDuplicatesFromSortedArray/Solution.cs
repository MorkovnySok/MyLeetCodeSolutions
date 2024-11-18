namespace LeetCode.RemoveDuplicatesFromSortedArray;

/// https://leetcode.com/problems/remove-duplicates-from-sorted-array/
public class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        int last = -9999;
        var lastUniquePosition = 0;
        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] == last)
            {
                continue;
            }

            last = nums[i];
            nums[lastUniquePosition] = nums[i];
            lastUniquePosition++;
        }

        return lastUniquePosition;
    }
}
