# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right

class Solution:
    def rightSideView(self, root: Optional[TreeNode]) -> List[int]:
        sol = []
        q = collections.deque([root])
        while(len(q)>0):
            level = []
            lenq = len(q)
            for i in range(lenq):
                node = q.popleft()
                if(node):
                    level.append(node.val)
                    q.append(node.left)
                    q.append(node.right)
            if level:
                sol.append(level[-1])
        return sol
            
