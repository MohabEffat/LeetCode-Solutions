public class Solution {
    public int MaxNumberOfBalloons(string text) {
        Dictionary<char, int> pair = new Dictionary<char, int>();
        string balloon = "balon";
        for(int i  = 0; i < balloon.Length; i++)
        {
            pair.Add(balloon[i], 0);
        }
        for (int i = 0; i < text.Length; i++)
        {
            if (!pair.ContainsKey(text[i]) && balloon.Contains(text[i]))
                pair.Add(text[i], 1);
            else if (pair.ContainsKey(text[i]))
                pair[text[i]]++;
        }
        pair['l'] /= 2;
        pair['o'] /= 2;
        return pair.Values.Min();
    }
}