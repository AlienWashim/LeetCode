public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int[] output = new int[2];
        for(int i = 0; i < nums.Length; i++){
            for(int j = i+1; j < nums.Length; j++){
                if(i != j && nums[i]+nums[j] == target){
                    output[0] = i;
                    output[1] = j;
                    return output;
                }
            }
        }
        return output;
    }
}
