namespace Triatleta
{
    public abstract class Pessoa
    {
        private string nome;

        public Pessoa(string nome)
        {
            this.nome = nome;
        }

        public string GetNome()
        {
            return nome;
        }

        public void SetNome(string nome)
        {
            this.nome = nome;
        }

        public void Cansou()
        {
            Console.WriteLine("\nCansou...\n");
        }
    }
}
