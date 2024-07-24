public class Solution {
    public int[] ReplaceElements(int[] arr) {
        int num = -1;
        for(int i = arr.Length - 1; i>= 0; i--){
            int n = arr[i];
            arr[i] = num;
            num = Math.Max(n, arr[i]);
            
        }
        return arr;
    }
}