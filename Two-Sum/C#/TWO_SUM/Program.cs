internal class Program
{
    private static void Main(string[] args)
    {
        int[] arr = { 2, 7, 11, 15 };
        int  target = 9;

        int []result = TwoSum(arr, target);

        for (int i = 0; i < result.Length; i++)
        {
            Console.WriteLine(result[i]);
        }

    }


public static int[] TwoSum(int[] nums, int target) {

        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i+1; j < nums.Length; j++)
            {

                if (nums[i] + nums[j] == target)
                {
                    int[] result = { i, j};

                    return result;
                }

            }

        }
        return new int[0];
        
    }
}