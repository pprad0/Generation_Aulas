namespace Transportes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Transporte t1 = new Transporte(5);

            t1.Visualizar();

            Console.WriteLine();

            Terrestre t2 = new Terrestre(4, 4, 100);

            t2.Visualizar();

            Automovel a1 = new Automovel(2, 2, "ABC1234", 200, "verde", 0, 5);

            a1.Visualizar();


        }
    }
}