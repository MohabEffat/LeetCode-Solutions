public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> indices = new Dictionary<int, int> ();
        for(int i = 0; i < nums.Length; i++){
            int temp = target - nums[i];
            if(indices.ContainsKey(temp))
                return new int[] { indices[temp], i };
            indices[nums[i]] = i;
        }
        return null;
    }
}