public class Solution {
    public bool IsPalindrome(string s) {
        int i=0;
        int j = s.Length-1;
        while(i<j){
            if(!isAlphaNumeric(s[i])){
                i++;
                continue;
            }
            if(!isAlphaNumeric(s[j])){
                j--;
                continue;
            }
            if(char.ToLower(s[i]) != char.ToLower(s[j])){
                return false;
            }
            i++;
            j--;
        }
        return true;
    }
    public bool isAlphaNumeric(char c){
        return (c>='a' && c<='z') || (c>='A' && c<='Z') || (c>='0' && c<='9');
    }
}
