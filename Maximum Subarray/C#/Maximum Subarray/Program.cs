internal class Program
{
    private static void Main(string[] args)
    {
        int[] nums = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
        

        Console.WriteLine(maxSubArray(nums));
    }


    public static int maxSubArray(int[] nums) {

        int currentSum = nums[0];
        int maxSum = nums[0];

        for (int i = 1; i < nums.Length; i++)
        {
            currentSum = Math.Max(nums[i], currentSum + nums[i]);

            maxSum = Math.Max(maxSum, currentSum);
        }

        return maxSum;
    }
}