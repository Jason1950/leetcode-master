# leetcode no: 1 by C#
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var numberDict = new Dictionary<int, int>();
        for(int i=0;i<nums.Length;i++){
            if( numberDict.ContainsKey(target - nums[i]) ){
                return new int[] { numberDict[target - nums[i]], i };
            }
            else if( !numberDict.ContainsKey(nums[i]) ){
                    numberDict.Add(nums[i],i);
            }
        }
        return default;
    }
}