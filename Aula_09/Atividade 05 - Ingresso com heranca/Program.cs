using Atividade_05___Ingresso_com_heranca.Model;

namespace Atividade_05___Ingresso_com_heranca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ingresso interestelar = new Ingresso(1, 4, "Interestelar", 10.00M, 2);
            interestelar.Visualizar();

            //Ingresso aorigem = new Ingresso(2, 4, "Inception", 22.00M, 1);
            //aorigem.Visualizar();


            Vip disney = new Vip(3, 3, "Barbie", 15, 2, "Coca cola e pipoca grátis");
            disney.Visualizar();


            MeiaEntrada wolverine = new MeiaEntrada(4, 1, "Wolverine", 20, 3, "Sim");
            wolverine.Visualizar();



        }
    }
}