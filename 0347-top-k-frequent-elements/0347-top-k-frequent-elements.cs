public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        int[] result = new int[k];
        Dictionary<int, int> pair = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (pair.ContainsKey(nums[i]))
                pair[nums[i]]++;
            else
                pair.Add(nums[i], 1);
        }
        List<KeyValuePair<int, int>> sortedPairs = new List<KeyValuePair<int, int>>(pair);

        sortedPairs.Sort((pair1, pair2) => pair2.Value.CompareTo(pair1.Value));
        for (int i = 0; i < k; i++)
        {
            result[i] = sortedPairs[i].Key;
        }
        return result;
    }
}