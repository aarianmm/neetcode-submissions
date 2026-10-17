public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, int> freqMap = new Dictionary<string, int>();
        List<List<string>> sol = new List<List<string>>();
        int groups = 0;
        for(int i=0; i<strs.Length; i++){
            int[] freq = new int[26];
            for(int j=0; j<strs[i].Length; j++){
                freq[strs[i][j]-'a']++;
                Console.WriteLine(strs[i][j]);
            }
            string strFreq = string.Join(",", freq);
            if(freqMap.ContainsKey(strFreq)){
                sol[freqMap[strFreq]].Add(strs[i]);
            }
            else{
                freqMap.Add(strFreq, groups);
                List<string> newGroup = new List<string>();
                newGroup.Add(strs[i]);
                sol.Add(newGroup);
                groups++;
            }
        }
        return sol;
    }
}
