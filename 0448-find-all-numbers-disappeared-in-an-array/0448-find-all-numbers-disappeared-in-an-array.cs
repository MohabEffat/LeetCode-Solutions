public class Solution {
    public IList<int> FindDisappearedNumbers(int[] nums) {
        Dictionary<int, int> Pair = new Dictionary<int, int>();
        IList<int> result = new List<int>();


        for (int i = 1; i <= nums.Length; i++)
        {
            Pair[i] = 0;
        }
        for (int i = 0; i < nums.Length; i++)
        {
            if (Pair.ContainsKey(nums[i]))
                Pair[nums[i]]++;
        }

        foreach (var item in Pair)
        {
            if (item.Value == 0)
                result.Add(item.Key);
        }
        return result;
    }
}