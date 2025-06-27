using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uni_DotNet_Practics3
{
    public class MaxSubarraySum
    {
        public int FindMaxSum(int[] nums)
        {
            if (nums == null || nums.Length == 0) return 0;

            int maxSum = nums[0];
            int currentSum = 0;

            foreach (int num in nums)
            {
                currentSum = Math.Max(num, currentSum + num);
                maxSum = Math.Max(maxSum, currentSum);
            }
            return maxSum;
        }
    }

}
