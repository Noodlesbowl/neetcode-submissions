public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> meBomba = [];
List<string> bomba = [];
for (int i = 0; i < strs.Length; i++)
{
    char[] temp = strs[i].ToCharArray();
    Array.Sort(temp);
    bomba.Add(new string(temp));
}

for (int i = 0; i < bomba.Count; i++)
{
    if (meBomba.ContainsKey(bomba[i]))
    {
        meBomba[bomba[i]].Add(strs[i]);
    }
    else
    {
        List<string> beep = [];
        beep.Add(strs[i]);
        meBomba.Add(bomba[i], beep);
    }
}
List<List<string>> retVal = [];
foreach (var yeet in meBomba)
{
    retVal.Add(yeet.Value);
}
return retVal;
    }
}
