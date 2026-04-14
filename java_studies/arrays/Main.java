package java_studies.arrays;
import java.util.Scanner;

public class Main {
    public static void main(String[] args){
        Scanner scanner = new Scanner(System.in);
        // int[] nums = new int[5];

        // for (int i = 0; i < nums.length; i++) {
        //     nums[i] = i;
        // }

        int[] nums = {1, 2, 3, 4 ,5};

        for (int i : nums) { //foreach
            System.out.println(i);
        }

    }
}
