public class Solution {
    public bool IsAnagram(string s, string t) {
       if (s.Length != t.Length)
       
            if (s.Length != t.Length)
                return false;
            char[] meep = s.ToCharArray();
            Array.Sort(meep);
            string sNew = new string(meep);

            char[] moop = t.ToCharArray();
            Array.Sort(moop);
            string tNew = new string(moop);

            for(int i = 0; i < s.Length; i++)
            {
                if (sNew[i] != tNew[i])
                    return false;
            }
            return true;
    }
}
