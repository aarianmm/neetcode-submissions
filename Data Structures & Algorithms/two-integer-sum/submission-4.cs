public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var valToIndex = new Dictionary<int, int>();
        for(int i=0; i<nums.Length; i++){
            if(valToIndex.ContainsKey(target-nums[i])){
                return new int[2] {valToIndex[target-nums[i]], i};
            }
            valToIndex[nums[i]]=i;
        }
        return new int[0];
    }
}
