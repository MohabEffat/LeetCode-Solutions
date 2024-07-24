public class Solution {
    public bool IsSubsequence(string s, string t) {
        int cnt = 0;
        if (s.Length == 0) return true;
        for (int i = 0, j = 0; i < t.Length && j < s.Length;)
        {
            if (s[j] == t[i])
            {
                j++;
                i++;
                cnt++;
            }
            else
                i++;
        }
        return cnt == s.Length;
    }
}