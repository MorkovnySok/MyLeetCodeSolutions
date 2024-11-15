using LeetCode.RemoveElement;

namespace TestProject.RemoveElement;

[TestFixture]
public class RemoveElementTests
{
    [Test]
    public void Test1()
    {
        var sol = new Solution();
        int[] nums = [3, 2, 2, 3];
        var k = sol.RemoveElement(nums, 3);
        Assert.That(k, Is.EqualTo(2));
        Assert.That(nums, Is.EquivalentTo(new[] { 2, 2 }));
    }

    [Test]
    public void Test2()
    {
        var sol = new Solution();
        int[] nums = [0, 1, 2, 2, 3, 0, 4, 2];
        var k = sol.RemoveElement(nums, 2);
        Assert.That(k, Is.EqualTo(5));
        Assert.That(nums, Is.EquivalentTo(new[] { 0, 1, 4, 0, 3, 2, 2, 2 }));
    }
}
