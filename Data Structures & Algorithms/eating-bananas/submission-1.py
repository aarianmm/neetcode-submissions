class Solution:
    def minEatingSpeed(self, piles: List[int], h: int) -> int:
        l, r = 1, max(piles)+1
        while l < r:
            mid = l + (r-l)//2
            hoursTaken = 0
            for p in piles:
                k = mid
                hoursTaken += p//k if p%k == 0 else p//k+1
                if hoursTaken > h:
                    l = mid+1
                    break
            if hoursTaken <= h:
                r = mid
        return l
                
