namespace Atividade_05___Ingresso_com_heranca.Model
{
    public class Ingresso
    {
        private int id;
        private int categoria;
        private string filme = string.Empty;
        private decimal valor;
        private int sala;


        //Construtor
        public Ingresso(int id, int categoria, string filme, decimal valor, int sala)
        {
            this.id = id;
            this.categoria = categoria;
            this.filme = filme;
            this.valor = valor;
            this.sala = sala;
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

        public int GetSala()
        {
            return sala;
        }

        public void SetSala(int sala)
        {
            this.sala = sala;
        }

        public string GetFilme()
        {
            return filme;
        }

        public void SetFilme(string filme)
        {
            this.filme = filme;
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
            string sala = "", categoria = "";

            switch (this.sala)
            {
                case 1:
                    sala = "Max 3D";
                    break;

                case 2:
                    sala = "Max 2D";
                    break;

                case 3:
                    sala = "Padrão";
                    break;

            }


            switch (this.categoria)
            {
                case 1:
                    categoria = "Terror";
                    break;

                case 2:
                    categoria = "Drama";
                    break;

                case 3:
                    categoria = "Comédia";
                    break;

                case 4:
                    categoria = "Ficção";
                    break;
            }

            Console.WriteLine("\n\n----------------------------------------");
            Console.WriteLine("\t Dados do produto");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine($" Id do produto: {this.id} ");
            Console.WriteLine($" Categoria do produto: {categoria}");
            Console.WriteLine($" Nome do filme: {this.filme}");
            Console.WriteLine($" Valor do ingresso: {this.valor}");
            Console.WriteLine($" Sala de cinema: {sala}");

        }
    }
}
