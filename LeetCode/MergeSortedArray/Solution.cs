namespace LeetCode.MergeSortedArray;

public class Solution
{
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        if (n == 0)
        {
            Array.Sort(nums1);
            return;
        }

        if (m == 0)
        {
            Array.Copy(nums2, nums1, n);
            Array.Sort(nums1);
            return;
        }

        for (var i = m; i < m + n; i++)
        {
            nums1[i] = nums2[i - m];
        }

        Array.Sort(nums1);
    }
}
