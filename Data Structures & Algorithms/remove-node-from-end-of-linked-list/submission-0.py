# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, val=0, next=None):
#         self.val = val
#         self.next = next

class Solution:
    def removeNthFromEnd(self, head: Optional[ListNode], n: int) -> Optional[ListNode]:
        node = head
        leng = 0
        while node:
            node = node.next
            leng+=1
        node = head
        i = 0
        prev = None
        while i<leng:
            if i == leng - n:
                if prev:
                    prev.next = node.next
                elif not prev:
                    head = node.next
            prev = node
            node = node.next
            i+=1
        return head

        
        