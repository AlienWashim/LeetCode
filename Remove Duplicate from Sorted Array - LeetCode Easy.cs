public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int numsSize = nums.Length;
        int k = 1;
        for(int i = 1; i < numsSize; i++){
            if(nums[i] != nums[i-1]){
                nums[k++] = nums[i];
            }
        }
        return k;
    }
}
