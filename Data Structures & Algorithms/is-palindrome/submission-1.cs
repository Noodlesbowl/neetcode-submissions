public class Solution {
    public bool IsPalindrome(string s) {
    string eval = string.Empty;
for(int i = 0; i < s.Length; i++)
{
    if (!Char.IsLetterOrDigit(s[i]))
    {
        continue;
    }
    eval += s[i];
}
eval = eval.ToUpper();

int left = 0;
int right = eval.Length - 1;
int mid = eval.Length / 2;

while (left < mid)
{
    if (eval[left] != eval[right])
        return false;

    left++;
    right--;
}
return true;
}
}