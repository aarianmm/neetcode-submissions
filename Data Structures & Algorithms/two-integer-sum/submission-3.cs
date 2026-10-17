public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var numToIndex = new Dictionary<int, int>();
        for(int i=0; i<nums.Length; i++){
            if(numToIndex.ContainsKey(target - nums[i]))
            {
                int j = numToIndex[target - nums[i]];
                return(new int[2] {j, i});
            }
            numToIndex[nums[i]] = i;
        }
        return new int[2];
    }
}
