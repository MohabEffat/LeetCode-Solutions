public class Solution {
    public bool IsIsomorphic(string s, string t) {
            Dictionary<char, char> dic1 = new Dictionary<char, char>();

            Dictionary<char, char> dic2 = new Dictionary<char, char>();
            for (int i = 0; i < s.Length; i++)
            {
                if (dic1.ContainsKey(s[i]))
                {
                    if (dic1[s[i]] != t[i])
                        return false;
                }
                else
                    dic1.Add(s[i], t[i]);

                if (dic2.ContainsKey(t[i]))
                {
                    if (dic2[t[i]] != s[i])
                        return false;
                }
                else
                    dic2.Add(t[i], s[i]);
            }
            return true;
    }
}