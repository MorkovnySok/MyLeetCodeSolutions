using LeetCode.RemoveDuplicatesFromSortedArray;

namespace TestProject.RemoveDuplicatesFromSortedArray;

[TestFixture]
public class Tests
{
    [Test]
    public void Test1()
    {
        var sol = new Solution();
        int[] nums = [1, 1, 2];
        var k = sol.RemoveDuplicates(nums);
        Assert.That(k, Is.EqualTo(2));
        Assert.That(nums.Take(k), Is.EquivalentTo(new[] { 1, 2 }));
    }

    [Test]
    public void Test3()
    {
        var sol = new Solution();
        int[] nums = [0, 0, 1, 1];
        var k = sol.RemoveDuplicates(nums);
        Assert.That(k, Is.EqualTo(2));
        Assert.That(nums.Take(k), Is.EquivalentTo(new[] { 0, 1 }));
    }

    [Test]
    public void Test2()
    {
        var sol = new Solution();
        int[] nums = [0, 0, 1, 1, 1, 2, 2, 3, 3, 4];
        var k = sol.RemoveDuplicates(nums);
        Assert.That(
            nums.Take(k),
            Is.EquivalentTo(new[] { 0, 1, 2, 3, 4 }),
            string.Join(", ", nums)
        );
    }
}
