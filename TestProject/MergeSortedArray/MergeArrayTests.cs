using LeetCode.MergeSortedArray;

namespace TestProject.MergeSortedArray;

[TestFixture]
public class MergeArrayTests
{
    [Test]
    public void Test1()
    {
        var sol = new Solution();
        var nums1 = new[] { 0 };
        var nums2 = new[] { 1 };
        sol.Merge(nums1, 0, nums2, 1);
        Assert.That(nums1.Length, Is.EqualTo(1));
        Assert.That(nums1[0], Is.EqualTo(1));
    }

    [Test]
    public void Test2()
    {
        var sol = new Solution();
        int[] nums1 = [4, 0, 0, 0, 0, 0];
        int[] nums2 = [1, 2, 3, 5, 6];
        sol.Merge(nums1, 1, nums2, 5);
        Assert.That(nums1.Length, Is.EqualTo(6));
        Assert.That(nums1, Is.EquivalentTo(new List<int> { 4, 1, 2, 3, 5, 6 }));
    }
}
