namespace Atividade_03___Produto_com_heranca.Model
{
    public class Jogo : Produto
    {
        private string categoria;
        public Jogo(int id, string nome, decimal valor, string categoria)
            : base(id, nome, valor)
        {
            this.categoria = categoria;
        }

        public string GetCategoria()
        {
            return categoria;
        }

        public void SetCategoria(string categoria)
        {
            this.categoria = categoria;
        }


        //Polimorfismo de sobrecarga
        public override void Visualizar()
        {
            base.Visualizar();
            Console.WriteLine($" Categoria do jogo: {this.categoria}");
        }
    }
}
