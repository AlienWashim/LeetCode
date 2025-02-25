public class Solution {
    public int RemoveDuplicates(int[] nums) {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        
        int numsSize = nums.Length;
        int k = 1;
        dict[nums[0]] = 1;
        for(int i = 1; i < numsSize; i++){
            if(!dict.ContainsKey(nums[i])){
                dict[nums[i]] = 1;
                nums[k++] = nums[i];
            }
            else if(dict[nums[i]] < 2){
                dict[nums[i]]++;
                nums[k++] = nums[i];
            }
        }
        return k;
    }
}
