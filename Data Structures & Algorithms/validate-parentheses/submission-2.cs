public class Solution {
    public bool IsValid(string s) {
        Stack<char> hold = [];
        int n = s.Length;
        for(int i = 0; i < n; i++)
        {
            if(s[i] == '(' || s[i] == '{' || s[i] == '[')
            {
                hold.Push(s[i]);
            }
            else if(hold.Count() == 0)
            {
                return false;
            }
            else if(s[i] == ')')
            {
                char top = hold.Peek();
                if(top != '(')
                {
                    return false;
                }
                else
                {
                    hold.Pop();
                }
            }
            else if(s[i] == ']')
            {
                char top = hold.Peek();
                if(top != '[')
                {
                    return false;
                }
                else
                {
                    hold.Pop();
                }
            }
            else if(s[i] == '}')
            {
                char top = hold.Peek();
                if(top != '{')
                {
                    return false;
                }
                else
                {
                    hold.Pop();
                }
            }
        }
        return hold.Count() == 0;
    }
}
