using Atividade_03___Produto_com_heranca.Model;

namespace Atividade_03___Produto_com_heranca
{
    public class Program
    {
        static void Main(string[] args)
        {

            Produto mario = new Produto(1, "Mario Bros", 10);
            mario.Visualizar();

            //polimorfismo
            Jogo reileao = new Jogo(3, "Rei leão 2", 5.5M, "Aventura");
            reileao.Visualizar();

            VideoGame pc = new VideoGame(4, "Computador", 2600, "Dell");
            pc.Visualizar();
        }
    }
}