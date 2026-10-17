public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int zeros = 0;
        int product =1;

        foreach(int num in nums){
            if(num ==0){
                zeros++;
            }
            else{
                product = product*num;
            }
        }
        int[] sol = new int[nums.Length];
        if(zeros>1){
            return sol;
        }
        for(int i=0; i<nums.Length; i++){
            if(zeros == 1 && nums[i]==0){
                sol[i] = product;
            }
            if(zeros == 0){
                sol[i] = product/nums[i];
            }
        }
        return sol;
    }
}
