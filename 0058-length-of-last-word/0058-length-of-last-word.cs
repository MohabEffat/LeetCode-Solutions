public class Solution {
    public int LengthOfLastWord(string s) {
        int cnt = 0;
        for (int i = s.Length -1 ; i>= 0 ; i--)
        {
            if (s[i] != ' ')
                cnt++;
            else if (cnt == 0)
                continue;
            else break;
        } 
        return cnt;
    }
}