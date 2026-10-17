class Solution:
    def combinationSum(self, nums: List[int], target: int) -> List[List[int]]:
        sol = []
        combination = []
        def dfs(i):
            if(i>=len(nums)):
                return
            tot = sum(combination)
            if(tot>target):
                return
            if(tot == target):
                sol.append(combination[:])
                return
            
            combination.append(nums[i])
            dfs(i)
            combination.pop()
            dfs(i+1)
        dfs(0)
        return sol