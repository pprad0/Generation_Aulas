namespace Atividade_03___Produto_com_heranca.Model
{
    public class VideoGame : Produto
    {
        private string marca;

        public VideoGame(int id, string nome, decimal valor, string marca)
            : base(id, nome, valor)
        {
            this.marca = marca;
        }

        public string GetMarca()
        {
            return marca;
        }

        public void SetMarca(string marca)
        {
            this.marca = marca;
        }


        //Polimorfismo de sobrecarga
        public override void Visualizar()
        {
            base.Visualizar();
            Console.WriteLine($" Marca do console/computador: {this.marca}");
        }
    }
}
