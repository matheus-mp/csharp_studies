namespace LongestProgramPrefix;

class Program
{
    public static void Main()
    {
        Console.WriteLine(LongestCommonPrefix(["Cachorro", "Carro"]));
    }

    public static string LongestCommonPrefix(string[] strs)
    {
        if (strs == null) throw new ArgumentNullException(nameof(strs));
        string prefix = "m";
        var L = "";
        for (int i = 0; i < strs.MinBy(s => s.Length).Length; i++)
        {
            foreach (var c in strs)
            {
                string cString = Convert.ToString(c[i]);
                if ((i == 0 && L == ""))
                {
                    L += cString;
                } else if (L != cString)
                {
                    break;
                } 
            }
        }

        return prefix;
    }
}