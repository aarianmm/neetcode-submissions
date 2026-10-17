public class Solution {
    public bool IsAnagram(string s, string t) {
        int[] freq = new int[26];
        if(s.Length!= t.Length){
            return false;
        }
        for(int i=0; i<s.Length; i++){
            freq[s[i]-'a']++;
            freq[t[i]-'a']--;
        }
        for(int i=0; i<26; i++){
            if(freq[i]!=0){
                return false;
            }
        }
        return true;
    }
}
