namespace RomanToInt;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(RomanInt("IV"));
    }

    public static int RomanInt(string r)
    {
        // int num = 0;
        // Dictionary<string, int> romanos = new()
        // {
        //     ["I"] = 1,
        //     ["IV"] = 4,
        //     ["V"] = 5,
        //     ["IX"] = 9,
        //     ["X"] = 10,
        //     ["XL"] = 40,
        //     ["L"] = 50,
        //     ["XC"] = 90,
        //     ["C"] = 100,
        //     ["CD"] = 400,
        //     ["D"] = 500,
        //     ["CM"] = 900,
        //     ["M"] = 1000
        // };
        //
        // for (int i = 0; i < r.Length; i++)
        // {
        //     string cString = Convert.ToString(r[i]);
        //     if (i < r.Length - 1)
        //     {
        //         if (cString == "I" && Convert.ToString(r[i + 1]) == "V")
        //         {
        //             cString = "IV";
        //             i++;
        //             num += romanos[cString];
        //         }
        //         else if (cString == "I" && Convert.ToString(r[i + 1]) == "X")
        //         {
        //             cString = "IX";
        //             i++;
        //             num += romanos[cString];
        //         } else if (cString == "X" && Convert.ToString(r[i + 1]) == "L")
        //         {
        //             cString = "XL";
        //             i++;
        //             num += romanos[cString];
        //         } else if (cString == "X" && Convert.ToString(r[i + 1]) == "C")
        //         {
        //             cString = "XC";
        //             i++;
        //             num += romanos[cString];
        //         } else if (cString == "C" && Convert.ToString(r[i + 1]) == "D")
        //         {
        //             cString = "CD";
        //             i++;
        //             num += romanos[cString];
        //         } else if (cString == "C" && Convert.ToString(r[i + 1]) == "M")
        //         {
        //             cString = "CM";
        //             i++;
        //             num += romanos[cString];
        //         }
        //         else
        //         {
        //             num += romanos[cString];
        //         }
        //     } else
        //     {
        //         num += romanos[cString];
        //     }
        // }
        //
        // return num;
        
        Dictionary<char, int> m = new Dictionary<char, int>()
        {
            {'I', 1},
            {'V',5},
            {'X',10},
            {'L',50},
            {'C',100},
            {'D',500},
            {'M',1000}
        };

        int total = 0;
        
        for(int i = 0; i < r.Length; i++)
        {
            if(i < r.Length - 1 && m[r[i]] < m[r[i+1]]) //caso o valor do indice seja menor que o adjacente será subtraído o valor; exemplo, se for IV, perde 1 e depois soma 5 
            {
                total = total - m[r[i]];
            }
            else
            {
                total = total + m[r[i]];
            }
        }

        return total;
    }
}