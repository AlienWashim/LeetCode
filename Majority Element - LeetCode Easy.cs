public class Solution {
    public int MajorityElement(int[] nums) {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        dict[nums[0]] = 1;

        int output = 0;
        int element = 0;

         for (int i = 1; i < nums.Length; i++){
            if (!dict.ContainsKey(nums[i])){
                 dict[nums[i]] = 1;
            }
            else{
                 dict[nums[i]]++;;
            }
         }

         foreach (int num in nums){
            if(dict[num] > output){
                output = dict[num];
                element = num;
            }
         }

         return element;
    }
}
