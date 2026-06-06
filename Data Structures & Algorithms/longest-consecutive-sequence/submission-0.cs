public class Solution {
    public  int LongestConsecutive(int[] nums)
{
    HashSet<int> ya = [];
    foreach (int yeet in nums)
    {
        ya.Add(yeet);
    }

    int max = 0;
    while (ya.Count > 0)
    {
        int seek = ya.First();
        ya.Remove(seek);

        int left = Rec(seek - 1, true, ref ya);
        int right = Rec(seek + 1, false, ref ya);

        max = Math.Max(left + right + 1, max);
    }
    return max;
}
public  int Rec(int number, bool isLeft, ref HashSet<int> nums)
{
    if (!nums.Contains(number))
        return 0;

    nums.Remove(number);

    if (isLeft)
    {
        return 1 + Rec(number - 1, true, ref nums);
    }
    else
    {
        return 1 + Rec(number + 1, false, ref nums);
    }
}
}
