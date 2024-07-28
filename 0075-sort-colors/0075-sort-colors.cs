public class Solution {
    public void SortColors(int[] nums) {
        int c0 = 0, c1 = 0, c2 = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 0) c0++;
            else if (nums[i] == 1) c1++;
            else c2++;
        }
        int index = 0;
        for (int i = 0; i < c0; i++)
            nums[index++] = 0;

        for (int i = 0; i < c1; i++)
            nums[index++] = 1;

        for (int i = 0; i < c2; i++)
            nums[index++] = 2;
    }
}