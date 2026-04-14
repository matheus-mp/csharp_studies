package csharp_studies.java_studies.romantoint;
import java.util.HashMap;
import java.util.Map;
import java.util.Scanner;

public class Main {
    public static void main(String[] args){
        System.out.print(romanToInt("XXIV"));
    }

    public static int romanToInt(String r) {
        Map<String, Integer> romanos = Map.of(
            "I", 1,
            "V", 5,
            "X", 10,
            "L", 50,
            "C", 100,
            "D", 500,
            "M", 1000
        );

        char[] rArray = r.toCharArray();
        int soma = 0;

        for(int i = 0; i < r.length(); i++){
            String rString = Character.toString(rArray[i]);
            
            if((i < r.length() - 1) && romanos.get(rString) < romanos.get(Character.toString(rArray[i + 1]))){
                soma -= romanos.get(rString);
            } else {
                soma += romanos.get(rString);
            }
        }

        return soma;
    }
}
