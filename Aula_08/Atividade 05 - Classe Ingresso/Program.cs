
using Atividade_05___Classe_Ingresso.Model;

internal class Program
{
    static void Main(string[] args)
    {
        Ingresso interestelar = new Ingresso(1, 4, "Interestelar", 10.00M, 2);
        interestelar.Visualizar();

        Ingresso aorigem = new Ingresso(2, 4, "Inception", 22.00M, 1);
        aorigem.Visualizar();
    }
}