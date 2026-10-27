# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, val=0, next=None):
#         self.val = val
#         self.next = next

class Solution:
    def mergeTwoLists(self, list1: Optional[ListNode], list2: Optional[ListNode]) -> Optional[ListNode]:
        if not list1:
            return list2
        if not list2:
            return list1
        if list1.val < list2.val:
            head = curr = list1
            next1 = list1.next 
            next2 = list2
        else:
            head = curr = list2
            next1 = list1
            next2 = list2.next
        while next1 and next2:
            if next1.val < next2.val:
                curr.next = next1
                next1=next1.next
            else:
                curr.next = next2
                next2=next2.next
            curr = curr.next
        if next1:
            curr.next = next1
        elif next2:
            curr.next = next2

        return head
        