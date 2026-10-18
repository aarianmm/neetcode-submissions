class Solution:
    def numIslands(self, grid: List[List[str]]) -> int:

        def dfs(i,j, first):
            nonlocal count
            if (i,j) in visited or i<0 or i>=len(grid) or j<0 or j>=len(grid[0]) or grid[i][j]=="0":
                return
            if(first):
                count+=1
            visited.add((i,j))
            
            dfs(i+1,j,False)
            dfs(i-1,j,False)
            dfs(i,j-1,False)
            dfs(i,j+1,False)
            return

        count = 0
        visited = set()
        for i in range(len(grid)):
            for j in range(len(grid[0])):
                dfs(i,j,True)
        return count



        
        