namespace IsPalindrome;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(IsPalindrome(-111));
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
            arrXs = xs.ToCharArray();

            Array.Reverse(arrXs);

            r = string.Join("", arrXs);
            
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
}