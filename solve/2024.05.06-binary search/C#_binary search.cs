// Example 1:
//
// Input: nums = [-1,0,3,5,9,12], target = 9
// Output: 4
// Explanation: 9 exists in nums and its index is 4
// Example 2:
//
// Input: nums = [-1,0,3,5,9,12], target = 2
// Output: -1
// Explanation: 2 does not exist in nums so return -1

// O(log n)

// 注意 l,h 的更新方式 及初始化 h= length-1

var solve = new Solution();
var ans =solve.Search(new int[] { -1, 0,5 },5);
Console.WriteLine("ans: "+ans);

public class Solution {
    public int Search(int[] nums, int target)
    {
        var (l, h) = (0,nums.Length-1);

        while (l<=h)
        {
            var middle = (int)Math.Floor((l+h) / 2.0);;
            Console.WriteLine($"l {l}, h {h}, m {middle}");
            if (nums[middle]==target)
            {
                return middle;
            }else if (nums[middle]>target)
            {
                h = middle - 1;
            }
            else
            {
                l = middle + 1;
            }
        }
        return -1;
    }
}