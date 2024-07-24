public class Solution {
    public string LongestCommonPrefix(string[] strs) {
            string ans = "";

            for (int i = 0; i < strs[0].Length; i++)
            {
                char x = strs[0][i];

                for (int j = 0; j < strs.Length; j++)
                {
                    if (i >= strs[j].Length || strs[j][i] != x)
                        return ans;
                }
                ans += x;
            }

            return ans;
    }
}