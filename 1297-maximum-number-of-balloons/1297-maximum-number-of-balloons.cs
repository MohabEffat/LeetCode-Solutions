public class Solution {
    public int MaxNumberOfBalloons(string text) {
        Dictionary<char, int> pair = new Dictionary<char, int>();

        for (int i = 0; i < text.Length; i++)
        {
            if (!pair.ContainsKey(text[i]))
                pair.Add(text[i], 1);
            else
                pair[text[i]]++;
        }
        int b = pair.ContainsKey('b') ? pair['b'] : 0;
        int a = pair.ContainsKey('a') ? pair['a'] : 0;
        int l = pair.ContainsKey('l') ? pair['l'] / 2 : 0;
        int o = pair.ContainsKey('o') ? pair['o'] / 2 : 0;
        int n = pair.ContainsKey('n') ? pair['n'] : 0;

        return Math.Min(Math.Min(a, b), Math.Min(Math.Min(l, o), n));
    }
}