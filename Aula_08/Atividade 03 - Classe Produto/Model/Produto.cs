namespace Atividade_03___Classe_Produto.Model
{
    public class Produto
    {
        private int id;
        private int categoria;
        private string nome = string.Empty;
        private decimal valor;
        private int plataforma;


        //Construtor
        public Produto(int id, int categoria, string nome, decimal valor, int plataforma)
        {
            this.id = id;
            this.categoria = categoria;
            this.nome = nome;
            this.valor = valor;
            this.plataforma = plataforma;
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
        public int GetCategoria()
        {
            return categoria;
        }

        public void SetCategoria(int categoria)
        {
            this.categoria = categoria;
        }

        public int GetPlataforma()
        {
            return plataforma;
        }

        public void SetPlataforma(int plataforma)
        {
            this.plataforma = plataforma;
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


        public void Visualizar()
        {
            string plataforma = "", categoria = "";

            switch (this.plataforma)
            {
                case 1:
                    plataforma = "PC";
                    break;

                case 2:
                    plataforma = "Playstation 5";
                    break;

                case 3:
                    plataforma = "Xbox Series";
                    break;

                case 4:
                    plataforma = "Multiplataforma";
                    break;
            }


            switch (this.categoria)
            {
                case 1:
                    categoria = "Terror";
                    break;

                case 2:
                    categoria = "FPS";
                    break;

                case 3:
                    categoria = "Puzzle";
                    break;

                case 4:
                    categoria = "Arcade";
                    break;
            }

            Console.WriteLine("\n\n----------------------------------------");
            Console.WriteLine("\t Dados do produto");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine($" Id do produto: {this.id} ");
            Console.WriteLine($" Categoria do produto: {categoria}");
            Console.WriteLine($" Nome do jogo: {this.nome}");
            Console.WriteLine($" Valor do jogo: {this.valor}");
            Console.WriteLine($" Plataforma: {plataforma}");
            Console.WriteLine("--------------------------------------------\n\n");

        }
    }
}
