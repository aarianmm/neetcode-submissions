# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, val=0, next=None):
#         self.val = val
#         self.next = next

class Solution:
    def reorderList(self, head: Optional[ListNode]) -> None:
        node = head
        nums = []
        rearranged = []
        while node:
            nums.append(node)
            node = node.next
        l, r = 0, len(nums)-1
        while l<r:
            rearranged.append(nums[l])
            rearranged.append(nums[r])
            l+=1
            r-=1
        if l == r:
            rearranged.append(nums[l])
        prev = rearranged[0]
        for n in rearranged[1:]:
            prev.next = n
            prev = n
        prev.next = None