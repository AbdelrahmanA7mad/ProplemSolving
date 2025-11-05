public class App {
    public static void main(String[] args) throws Exception {
        System.out.println("Hello, World!");
    }
    public static int MaxSubArray(int[] nums) {



        int max = nums[0];
        int cuurent = nums[0];


        for (int i = 1 ; i < nums.length ; i++){

                cuurent = Math.max(nums[i], cuurent + nums[i]);
                max = Math.max(max, cuurent);

        }

        return max;
    }
}
