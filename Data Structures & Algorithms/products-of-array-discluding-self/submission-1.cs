public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int N = nums.Length;
        int[] cumuR = new int[N];
        cumuR[0] = nums[0];
        int[] cumuL = new int[N];
        cumuL[N-1] = nums[N-1];
        for(int i=1; i<N; i++){
            cumuR[i]=nums[i]*cumuR[i-1];
        }
        for(int i=N-2; i>0; i--){
            cumuL[i]=nums[i]*cumuL[i+1];
        }
        int[] sol = new int[N];
        sol[0] = cumuL[1];
        sol[N-1] = cumuR[N-2];
        for(int i=1; i<N-1; i++){
            sol[i] = cumuR[i-1]*cumuL[i+1];
        }
        return sol;
    }
}
