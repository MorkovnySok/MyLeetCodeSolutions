using LeetCode.AddTwoNumbersAsLinkedList;

namespace TestProject.AddTwoNumbersAsLinkedList;

public class Tests
{
    [Test]
    public void Test1()
    {
        var sol = new Solution();
        var res = sol.AddTwoNumbers(new ListNode(1), new ListNode(1));
        Assert.That(res.val, Is.EqualTo(2));
    }

    [Test]
    public void Test2()
    {
        var sol = new Solution();
        var res = sol.AddTwoNumbers(new ListNode(9), new ListNode(1));
        Assert.That(res.val, Is.EqualTo(0));
        Assert.That(sol.carryOver, Is.True);
    }

    [Test]
    public void Test3()
    {
        var sol = new Solution();
        var res = sol.AddTwoNumbers(new ListNode(9), new ListNode(2));
        Assert.That(res.val, Is.EqualTo(1));
        Assert.That(sol.carryOver, Is.True);
    }

    [Test]
    public void Test4()
    {
        var sol = new Solution();
        var res = sol.AddTwoNumbers(
            new ListNode(1, new ListNode(2)),
            new ListNode(1, new ListNode(2))
        );
        Assert.That(res.val, Is.EqualTo(2));
        Assert.That(res.next!.val, Is.EqualTo(4));
    }

    [Test]
    public void Test5()
    {
        var sol = new Solution();
        var res = sol.AddTwoNumbers(
            new ListNode(1, new ListNode(2, new ListNode(3))),
            new ListNode(1, new ListNode(2))
        );
        //342
        Assert.That(res.val, Is.EqualTo(2));
        Assert.That(res.next!.val, Is.EqualTo(4));
        Assert.That(res.next!.next!.val, Is.EqualTo(3));
    }

    [Test]
    public void Test6()
    {
        var sol = new Solution();
        var res = sol.AddTwoNumbers(
            new ListNode(9, new ListNode(9, new ListNode(9))),
            new ListNode(9, new ListNode(9))
        );
        //1098
        Assert.That(res.val, Is.EqualTo(8));
        Assert.That(res.next!.val, Is.EqualTo(9));
        Assert.That(res.next!.next!.val, Is.EqualTo(0));
        Assert.That(res.next!.next!.next!.val, Is.EqualTo(1));
    }

    [Test]
    public void Test7()
    {
        var sol = new Solution();
        var res = sol.AddTwoNumbers(
            new ListNode(2, new ListNode(4, new ListNode(9))),
            new ListNode(5, new ListNode(6, new ListNode(4, new ListNode(9))))
        );
        //942 + 9465 = 10407
        Assert.That(res.val, Is.EqualTo(7));
        Assert.That(res.next!.val, Is.EqualTo(0));
        Assert.That(res.next.next!.val, Is.EqualTo(4));
        Assert.That(res.next.next.next!.val, Is.EqualTo(0));
        Assert.That(res.next.next.next.next!.val, Is.EqualTo(1));
    }

    [Test]
    public void Test8()
    {
        var sol = new Solution();
        var res = sol.AddTwoNumbers(
            new ListNode(9, new ListNode(9, new ListNode(1))),
            new ListNode(1)
        );
        //199 + 1 = 200
        Assert.That(res.val, Is.EqualTo(0));
        Assert.That(res.next!.val, Is.EqualTo(0));
        Assert.That(res.next.next!.val, Is.EqualTo(2));
        Assert.That(res.next.next.next, Is.Null);
    }

    [Test]
    public void Test9()
    {
        var sol = new Solution();
        var res = sol.AddTwoNumbers(new ListNode(5), new ListNode(5));
        Assert.That(res.val, Is.EqualTo(0));
        Assert.That(res.next!.val, Is.EqualTo(1));
    }

    [Test]
    public void Test10()
    {
        var sol = new Solution();
        var res = sol.AddTwoNumbers(new ListNode(9), new ListNode(9));
        Assert.That(res.val, Is.EqualTo(8));
        Assert.That(res.next!.val, Is.EqualTo(1));
    }
}
