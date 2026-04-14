package csharp_studies.java_studies.fibonacci;
import java.util.Scanner;

public class Main {
    public static void main(String[] args){
        Scanner scanner = new Scanner(System.in);

        System.out.print("Digite quantos dígitos a sequência deve ter: ");
        int qtd = scanner.nextInt();

        int n1 = 1, n2 = 1, n3;

        for (int i = 1; i <= qtd; i++){
            if (i < 3) {
                System.out.print(n1 + " ");
            } else{
                n3 = n1 + n2;
                System.out.print(n3 + " ");
                n1 = n2;
                n2 = n3;
            }
        }
    }
}
