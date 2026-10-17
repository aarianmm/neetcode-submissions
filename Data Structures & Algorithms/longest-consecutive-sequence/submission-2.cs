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
        int length = 0;
        while(length<nums.Length){
            length++;
            for(int i=start.Count-1; i>=0; i--){
                if(!numsSet.Contains(start[i]+length)){
                    start.RemoveAt(i);
                }
                if(start.Count == 0){
                    return length;
                }
            }
        }
        return length;
    }
}