public class Solution {
    public bool IsValid(string s) {
        var open = new Stack<char>();
        foreach(char c in s){
            if(c == '(' || c == '{' || c == '['){
                open.Push(c);
            }
            else if(c == ')' || c == '}' || c == ']'){
                if(open.Count() == 0 || closingBracket(open.Pop()) != c){
                    return false;
                }
            }
        }
        if(open.Count() != 0)  return false;
        return true;
    }
    char closingBracket(char opening){
        if(opening == '(')  return ')';
        if(opening == '[')  return ']';
        if(opening == '{')  return '}';
        return '!';
    }
}
