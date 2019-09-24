using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace likou
{
    public class liangshixaingjia
    {
        public static void start()
        {
            ListNode nums = new ListNode(2);
            nums.next= new ListNode(4);
            nums.next.next = new ListNode(3);
            ListNode nums1 = new ListNode(5);
            nums1.next = new ListNode(6);
            nums1.next.next = new ListNode(4);
            var s = AddTwoNumbers(nums, nums1);
            
        }

        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode root = new ListNode(0);
            ListNode cursor = root;
            int carry = 0;
            while (l1 != null || l2 != null || carry != 0)
            {
                int l1Val = l1 != null ? l1.val : 0;
                int l2Val = l2 != null ? l2.val : 0;
                int sumVal = l1Val + l2Val + carry;
                carry = sumVal / 10;

                ListNode sumNode = new ListNode(sumVal % 10);
                cursor.next = sumNode;
                cursor = sumNode;

                if (l1 != null) l1 = l1.next;
                if (l2 != null) l2 = l2.next;
            }

            return root.next;
        }
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }
    }
}
