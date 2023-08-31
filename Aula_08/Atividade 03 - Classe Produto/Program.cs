using Atividade_03___Classe_Produto.Model;

namespace Atividade_03___Classe_Produto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto mario = new Produto(1, 4, "Mario Bros", 5.00M, 4);
            mario.Visualizar();

            Produto cod = new Produto(2, 2, "Call of Duty Warzone", 2000.00M, 1);
            cod.Visualizar();
        }
    }
}