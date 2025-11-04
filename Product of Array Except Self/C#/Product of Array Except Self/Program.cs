internal class Program
{
    private static void Main(string[] args)
    {
        int[] arr = {0,0 };


        int[] newarr = productExceptSelf(arr);

        for (int i = 0; i < newarr.Length; i++)
        {
            Console.WriteLine(newarr[i]);
        }

    }
    public static int[] productExceptSelf(int[] nums)
    {
        int[] newArray = new int[nums.Length];

        int zerocount = 0;
        int sum = 1;

        for (int i = 0; i < nums.Length; i++)
        {
            sum = sum * nums[i];
        }   

        for (int i = 0; i < nums.Length; i++)
        {

            if (nums[i] == 0 && zerocount == 0)
            {
                zerocount++;

                int Zerosum = 1;
                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[j] == 0)
                    {
                        continue;
                    }
                    Zerosum = Zerosum * nums[j];

                }

                 newArray[i] = Zerosum;


            }
            else if (nums[i] == 0 && zerocount > 0)
            {

                for (int j = 0; j < nums.Length; j++)
                {
                    newArray[j] = 0;
                }

            }
            else
            {
                newArray[i] = sum / nums[i];
            }


        }

        return newArray;


    }

}