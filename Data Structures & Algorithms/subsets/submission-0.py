class Solution:
    def subsets(self, nums: List[int]) -> List[List[int]]:
        sol = []
        subset = []
        def dfs(i): #maybe include ith element
            if(i>=len(nums)):
                sol.append(subset[:])
                return
                
            subset.append(nums[i])
            dfs(i+1)
            subset.pop()
            dfs(i+1)
        dfs(0)
        return sol

        