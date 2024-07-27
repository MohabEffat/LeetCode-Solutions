public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> pair = new Dictionary<string, List<string>>();
        IList<IList<string>> strings = new List<IList<string>>();

        for (int i = 0; i < strs.Length; i++)
        {
            char[] chars = strs[i].ToCharArray();
            Array.Sort(chars);
            if (pair.ContainsKey(new string(chars)))
                pair[new string(chars)].Add(strs[i]);
            else
                pair.Add(new string(chars), new List<string> { strs[i] });
        }
        foreach (var item in pair)
        {
            strings.Add(item.Value);
        }
        return strings;
    }
}