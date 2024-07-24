public class Solution {
    public bool ContainsDuplicate(int[] nums) {
       Dictionary<int, int> dic = new Dictionary<int, int>();
        bool flag = false;
        for (int i = 0; i < nums.Length; i++)
        {
            if (dic.ContainsKey(nums[i]))
            {
                flag = true;
                break;
            }
            else
                dic.Add(nums[i], 1);
        }
        return flag; 
    }
}