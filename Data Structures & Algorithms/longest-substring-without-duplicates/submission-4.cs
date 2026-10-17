public class Solution {
    public int LengthOfLongestSubstring(string s) {
        var seen = new HashSet<char>();
        int l = 0;
        int r =0;
        int longest = 0;
        while(r<s.Length){
            char c = s[r];
            while(seen.Contains(c)){
                seen.Remove(s[l]);
                l++;    
            }
            seen.Add(c);
            for(int i=l; i<=r; i++){
                Console.Write(s[i]);
            }
            Console.WriteLine();
            longest = Math.Max(longest, r-l+1);
            r++;
        }       
        return longest;
    }
}