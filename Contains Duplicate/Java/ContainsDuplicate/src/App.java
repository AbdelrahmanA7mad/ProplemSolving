import java.util.HashSet;

public class App {
    public static void main(String[] args) throws Exception {

        int [] arr = {1,1,2,3};

        System.out.println(ContainsDuplicate(arr));

    }


     public static boolean ContainsDuplicate(int[] nums) {

            HashSet<Integer> numbers = new HashSet<Integer>();


            for(int num : nums){

                if (numbers.contains(num)){

                    return true;
                }
                else{

                numbers.add(num);
            }
        
        }
    return false;
       


    }
}
