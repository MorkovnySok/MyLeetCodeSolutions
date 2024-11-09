// https://leetcode.com/problems/add-two-numbers/description/
namespace LeetCode.AddTwoNumbersAsLinkedList;

public class ListNode(int val = 0, ListNode? next = null)
{
    public readonly int val = val;
    public ListNode? next = next;
}

public class Solution
{
    public bool carryOver = false;
    private ListNode? previousNode = null;

    public ListNode AddTwoNumbers(ListNode? l1, ListNode? l2)
    {
        l2 ??= new ListNode(0);
        l1 ??= new ListNode(0);

        var result = l1.val + l2.val;
        if (carryOver)
        {
            result += 1;
            carryOver = false;
        }
        if (result >= 10)
        {
            carryOver = true;
            result %= 10;
        }

        var resultNode = new ListNode(result);
        if (previousNode != null)
        {
            previousNode.next = resultNode;
        }

        previousNode = resultNode;

        if (l1.next is not null || l2.next is not null)
        {
            resultNode.next = AddTwoNumbers(l1.next, l2.next);
        }

        if (carryOver && l1.next is null && l2.next is null)
        {
            resultNode.next = new ListNode(1);
        }
        return resultNode;
    }
}
