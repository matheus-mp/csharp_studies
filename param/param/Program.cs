namespace  program;

class Program
{
    static void Main()
    {
        int r;
        soma(out r, 2, 5, 4);
        Console.WriteLine("Argumento Out: " + r);
    }

    static void soma(out int resto, params int[] n)
    {
        int res = 0;

        if (n.Length < 1)
        {
            Console.WriteLine("Não existem valores a serem somados");
        } else if (n.Length < 2)
        {
            Console.WriteLine("Valores insuficientes para soma: " + n[0]);
        }
        else
        {
            for (int i = 0; i < n.Length; i++)
            {
                res += n[i];
            }
            Console.WriteLine("A soma dos valores é: " + res);
        }

        resto = res;
    }
}