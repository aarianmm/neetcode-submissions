public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> numsSet = new HashSet<int>(nums);
        int longest = 0;
        List<int> start = new List<int>();
        foreach(int n in nums){
            if (!numsSet.Contains(n-1)){
                start.Add(n);
            }
        }
        foreach(int n in nums){
            int length = 1;
            int m = n;
            while(numsSet.Contains(m+1)){
                length++;
                m++;
            }
            if(length > longest){
                longest = length;
            }
        }
        return longest;
    }
}