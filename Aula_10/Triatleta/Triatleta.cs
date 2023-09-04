namespace Triatleta
{
    public class Triatleta : Pessoa, ICiclista, ICorredor, INadador
    {
        public Triatleta(string nome) : base(nome)
        {

        }

        public void Aquecer()
        {
            Console.WriteLine("\nAquecendo...\n");
        }

        public void Correr()
        {
            Console.WriteLine("\nCorrendo...\n");

        }

        public void Nadar()
        {
            Console.WriteLine("\nNadando...\n");

        }

        public void Pedalar()
        {
            Console.WriteLine("\nPedalando...\n");

        }



    }
}
