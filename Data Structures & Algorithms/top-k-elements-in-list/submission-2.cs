public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> numToFreq = new Dictionary<int, int>();
        foreach(int num in nums){
            if(numToFreq.ContainsKey(num)){
                numToFreq[num]++;
            }
            else{
                numToFreq.Add(num, 1);
            }
        }
        Stack<int>[] freqToNums = new Stack<int>[nums.Length+1];
        foreach (KeyValuePair<int, int> kvp in numToFreq){
            int num = kvp.Key;
            int freq = kvp.Value;
            
            if(freqToNums[freq]==null){
                freqToNums[freq] = new Stack<int>();
            }
            freqToNums[freq].Push(num);
        }
        int[] sol = new int[k];
        int j=0;
        int currentFreq = nums.Length;
        while(currentFreq>0){
            var currentNums = freqToNums[currentFreq];
            if(currentNums!=null && currentNums.Count()!=0){
                sol[j]=currentNums.Pop();
                j++;
            }
            else{
                currentFreq--;
            }
            if(j==k){
                return sol;
            }

        }
        return sol;
    }
}
