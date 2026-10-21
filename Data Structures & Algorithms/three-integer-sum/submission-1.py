class Solution:
    def threeSum(self, nums: List[int]) -> List[List[int]]:
        sol = set()
        nums.sort()
        i, cont = 0, True
        while(i<=len(nums)-3):
            if(i>0 and nums[i] == nums[i-1]):
                i+=1
                continue
            
            l, r = i+1, len(nums)-1
            while(l<r):
                tsum = nums[i]+nums[l]+nums[r]
                if(tsum<0):
                    l+=1
                elif(tsum>0):
                    r-=1
                else:
                    sol.add((nums[i], nums[l], nums[r]))
                    l+=1
                    r-=1
            i+=1
        return [list(triple) for triple in sol]


        