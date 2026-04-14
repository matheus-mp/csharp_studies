namespace IsPalindrome;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(IsPalindrome2(111));
    }

    public static bool IsPalindrome(int x)
    {
        bool pal;
        string xs = Convert.ToString(x);
        string r;
        char[] arrXs = new char[xs.Length];
        if (x < 0)
        {
            pal = false;
        }
        else
        {
            arrXs = xs.ToCharArray(); //Converte o string para um array do tipo char

            Array.Reverse(arrXs);

            r = string.Join("", arrXs); //Recebe o array como um string: "" é o parâmetro do que deve ter entre cada elemento
            
            if (r == xs)
            {
                pal = true;
            }
            else
            {
                pal = false;
            }
        }
        
        return pal;
    }

    public static bool IsPalindrome2(int x)
    {
        if (x < 0 || x % 10 == 0 && x < 0) return false; // Verifica se o número é menor que 0 ou se é terminado em 0

        int metadeInvertida = 0;

        while (x > metadeInvertida)
        {
            metadeInvertida = metadeInvertida * 10 + x % 10; //x % 10 pega o último dígito. metadeInvertida * 10 puxa o segundo dígito quando se torna maior que 0; Exemplo: 3 * 10 + 3 % 10 retorna o valor de 30
            x /= 10; //tira o último dígito
        }
        
        //x == metadeInvertida -> número par
        //x == metadeInvertida / 10 -> número ímpar (pq ímpar terá um número a mais)
        return x == metadeInvertida || x == metadeInvertida / 10;
    }
}