public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        HashSet<int> result = new HashSet<int>();
        foreach (int i in nums)
        {
            if(!result.Add(i))
                return true;
        }
        return false;
    }
}