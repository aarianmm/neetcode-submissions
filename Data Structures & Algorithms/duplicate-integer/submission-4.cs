public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> seen = new HashSet<int>();
        foreach(int n in nums){
            if(!seen.Contains(n)){
                seen.Add(n);
            }
            else{
                return true;
            }
        }
        return false;
    }
}