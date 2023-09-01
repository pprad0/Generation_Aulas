namespace Transportes
{
    public class Transporte
    {
        private int capacidade;

        public Transporte(int capacidade)
        {
            this.capacidade = capacidade;
        }

        public int GetCapacidade()
        {
            return this.capacidade;
        }

        public void SetCapacidade(int capacidade)
        {
            this.capacidade = capacidade;
        }




        public virtual void Visualizar()
        {
            Console.WriteLine("\n\n--------------------------------------");
            Console.WriteLine("\t Meio de transporte");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine($"Capacidade: {this.capacidade}");

            //Console.WriteLine($"Outras propriedades em override Terrestre.cs ");
            //Console.WriteLine($"");
            //Console.WriteLine($"");
            //Console.WriteLine($"");
        }
    }
}
