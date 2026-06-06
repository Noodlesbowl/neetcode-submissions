public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        
        List<List<string>> returnList = new List<List<string>>();
        
        for (int i = 0; i < strs.Length; i++)
        {
            List<string> entries = new List<string>();

            if(i == 0)
            {
                entries.Add(strs[i]);
                returnList.Add(entries);
                continue;
            }

            for (int j = 0; j < returnList.Count; j++)
            {
                var x = new string(strs[i].OrderBy(x=>x).ToArray());
                var y = new string(returnList[j].First().OrderBy(x=>x).ToArray());

                if(strs[i].Length == returnList[j][0].Length)
                {
                    if(x == y)
                    {
                        Console.WriteLine(x + y);
                        returnList[j].Add(strs[i]);
                        break;
                    }
                    else
                    {
                        if(j == returnList.Count - 1)
                        {
                            entries.Add(strs[i]);
                            returnList.Add(entries);
                            break;
                        }
                        continue;
                    }
                }
                else
                {
                    if(j == returnList.Count - 1)
                    {
                        entries.Add(strs[i]);
                        returnList.Add(entries);
                        break;
                    }
                    continue;
                }
            }
        }

        return returnList;
    }
}
