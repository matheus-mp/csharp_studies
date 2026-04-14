import java.math.BigDecimal;
import java.math.RoundingMode;
import java.util.Scanner;

public class Soma{
    public static void main(String[] args){
        Scanner scanner = new Scanner(System.in);

        System.out.print("Digite o primeiro número: ");
        double num1 = scanner.nextDouble();
        
        scanner.nextLine();

        System.out.print("Digite o segundo número: ");
        double num2 = scanner.nextDouble();

        BigDecimal bd = new BigDecimal(num1 + num2);
        bd = bd.setScale(2, RoundingMode.HALF_UP);
        System.out.print(bd);
    }
}