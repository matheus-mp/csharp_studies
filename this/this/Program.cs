class Calculos
{
    public int v1, v2;

    public Calculos(int v1, int v2)
    {
        this.v1 = v1;
        this.v2 = v2;
    }
    
    public int Somar()
    {
        return v1 + v2;
    }
}

class Program
{
    static void Main()
    {
        Calculos calc1 = new Calculos(10, 2);
        
        Console.WriteLine(calc1.Somar());
    }
}