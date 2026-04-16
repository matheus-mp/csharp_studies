// [ModificadorClasse] class NOME_DA_CLASSE{
//     //Variáveis / propriedades
//     [EspecificadorAcesso] tipo NOME_PROPRIEDADE;
//
//     //Métodos
//     [EspecificadorAcesso] retorno NOME_MÉTODO([arg1,...]){
//         //Corpo do método
//     }
// }

//ModificadorClasse: Define a visibilidade da classe
//public: Pública, sem restrição de visualização
//abstract: Classe-Base para outras classes, não podem ser
    //instanciados objetos desta classe
//sealed: Classe não pode ser herdada
//static: Classe não permite a instanciação de objetos e seus
    //membros devem ser static

//EspecificadorAcesso: Onde um membro da classe pode ser acessado
//public: Sem restrição de acesso
//private: Só podem ser acessador pela própria classe
//protected: Podem ser acessados na própria classe e nas classes
    //derivadas
//abstract: Os métodos não tem implementação somente os cabeçalhos
//sealed: o método não pode ser redefinido
//virtual: o método pode ser redefinido em uma classe derivada
//static: o método pode ser chamado mesmo sem a instanciação de
    //um objeto

public class Jogador : IDisposable //sempre maiusculo
{
    public int energia;
    public bool vivo;
    public string nome;
    
    public Jogador(string n)
    {
        energia = 1000;
        vivo = true;
        nome = n;
    }

    public Jogador()
    {
        energia = 1000;
        vivo = true;
        nome = "Jogador";
    }

    public void info()
    {
        Console.WriteLine("Nome do jogador: " + nome);
        Console.WriteLine("Energia do jogador: " + energia);
        Console.WriteLine("Vida do jogador: " + vivo);
    }

    public void Dispose()
    {
        Console.WriteLine("Destruido!");
    }

    // ~Jogador()
    // {
    //     Console.WriteLine("Destruído!"); Último recurso, pois é imprevisível
    // }
}

class Program
{
    static void Main()
    {
        Jogador j1 = new Jogador();
        Jogador j2 = new Jogador("Marcelinho");

        j1.info();
        j2.info();
    }
}