public class Solution {
    public int CharacterReplacement(string s, int k) {
        int[] freq = new int[26];
        int l=0;
        int r=0;
        int longest = 0;
        while(r<s.Length){
            freq[s[r]-'A']++;
            while(freq.Max()+k<(r-l+1)){
                freq[s[l]-'A']--;
                l++;
            }
            longest = Math.Max(longest, r-l+1);
            r++;
        }
        return longest;
    }
}
