namespace Atividade_03___Produto_com_heranca.Model
{
    public class Produto
    {
        private int id;
        private string nome = string.Empty;
        private decimal valor;


        //Construtor
        public Produto(int id, string nome, decimal valor)
        {
            this.id = id;
            this.nome = nome;
            this.valor = valor;
        }


        //Get e Set


        public int GetId()
        {
            return id;
        }

        public void SetId(int id)
        {
            this.id = id;
        }


        public string GetNome()
        {
            return nome;
        }

        public void SetNome(string nome)
        {
            this.nome = nome;
        }

        public decimal GetValor()
        {
            return valor;
        }

        public void SetValor(decimal valor)
        {
            this.valor = valor;
        }


        public virtual void Visualizar()
        {
            Console.WriteLine("\n\n----------------------------------------");
            Console.WriteLine("\t Dados do produto");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine($" Id do produto: {this.id} ");
            Console.WriteLine($" Nome do produto: {this.nome}");
            Console.WriteLine($" Valor do produto: {this.valor}");

        }
    }
}
