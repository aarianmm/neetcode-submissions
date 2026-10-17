public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> seenIndex = new Dictionary<int, int>();
        int[] sol = new int[2];
        for(int i=0; i<nums.Length; i++){
            sol[1]=i;
            if(seenIndex.ContainsKey(target-nums[i])){
                sol[0] = seenIndex[target-nums[i]];
                return sol;
            }
            else{
                seenIndex.Add(nums[i], i);
            }
        }
        return sol;
    }
}
