class Solution:
    def searchMatrix(self, matrix: List[List[int]], target: int) -> bool:
        size = len(matrix)*len(matrix[0])
        l, r = 0, size-1
        def entry(i) -> int:
            row, col = i//len(matrix[0]), i%len(matrix[0])
            return matrix[row][col]
        while l<r:
            mid = l+(r-l)//2
            if entry(mid) == target:
                return True
            if entry(mid) < target:
                l=mid+1
            else:
                r=mid-1
        return entry(l)==target