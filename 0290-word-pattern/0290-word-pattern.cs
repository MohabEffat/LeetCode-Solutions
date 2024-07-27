public class Solution {
    public bool WordPattern(string pattern, string s) {
        string[] str = s.Split(' ');
        Dictionary<char, string> pair1 = new Dictionary<char, string>();

        Dictionary<string, char> pair2 = new Dictionary<string, char>();
        if(str.Length != pattern.Length)
            return false;
        for (int i = 0; i < pattern.Length; i++)
        {
            if (pair1.ContainsKey(pattern[i]))
            {
                if (pair1[pattern[i]] != str[i])
                    return false;
            }
            else
                pair1.Add(pattern[i], str[i]);

            if (pair2.ContainsKey(str[i]))
            {
                if (pair2[str[i]] != pattern[i])
                    return false;
            }
            else
                pair2.Add(str[i], pattern[i]);
        }
        return true;
    }
}