namespace Atividade_05___Ingresso_com_heranca.Model
{
    public class Vip : Ingresso
    {
        private string brinde;
        public Vip(int id, int categoria, string filme, decimal valor, int sala, string brinde)
            : base(id, categoria, filme, valor, sala)
        {
            this.brinde = brinde;
        }

        public string GetBrinde()
        {
            return brinde;
        }

        public void SetBrinde(string brinde)
        {
            this.brinde = brinde;
        }

        //Polimorfismo de sobrecarga

        public override void Visualizar()
        {
            base.Visualizar();
            Console.WriteLine($" Brinde VIP: {this.brinde}");
        }
    }
}
