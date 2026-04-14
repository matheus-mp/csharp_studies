package csharp_studies.java_studies.longerprefix;

public class Main {
    public static void main(String[] args) {
        System.out.println(longerPrefix(new String[]{"cachorro", "carro", "marlinhos"}));
    }

    public static String longerPrefix(String[] words) {
        // Assumimos inicialmente que a menor palavra será a base para o prefixo
        String minor = words[0];

        // Encontramos a menor palavra
        for (int i = 1; i < words.length; i++) {
            if (words[i].length() < minor.length()) {
                minor = words[i];
            }
        }

        // Prefixo comum (inicia vazio)
        String prefix = "";

        // Vamos verificar os caracteres de 0 até o tamanho da menor palavra
        for (int i = 0; i < minor.length(); i++) {
            char currentChar = minor.charAt(i); //puxa o caractere do indice

            // Verifica se todas as palavras começam com o prefixo até a posição i
            for (String word : words) {
                // Se qualquer palavra não tiver o caractere esperado, interrompemos
                if (word.charAt(i) != currentChar) {
                    return prefix;  // Retorna o prefixo encontrado até o momento
                }
            }

            // Se todas as palavras têm o caractere esperado, adicionamos ao prefixo
            prefix += currentChar;
        }

        return prefix;  // Retorna o prefixo comum encontrado
    }
}