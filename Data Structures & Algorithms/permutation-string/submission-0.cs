public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        var s1LettersLeft = new int[26];
        foreach(char c in s1){
            s1LettersLeft[c-'a']++;
        }
        if(s1.Length > s2.Length){
            return false;
        }
        int l=0, r=0;
        while(r<s2.Length){
            s1LettersLeft[s2[r]-'a']--;
            while(s1LettersLeft[s2[r]-'a'] < 0){
                s1LettersLeft[s2[l]-'a']++;
                l++;
            }
            if((r-l+1)==s1.Length){
                return true;
            }
            r++;
        }
        return false;
    }
}
