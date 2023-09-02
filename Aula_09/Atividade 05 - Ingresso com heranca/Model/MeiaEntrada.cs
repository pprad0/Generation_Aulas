namespace Atividade_05___Ingresso_com_heranca.Model
{
    public class MeiaEntrada : Ingresso
    {
        private string estudante;
        public MeiaEntrada(int id, int categoria, string filme, decimal valor, int sala, string estudante)
            : base(id, categoria, filme, valor, sala)
        {
            this.estudante = estudante;
        }

        public string GetEstudante()
        {
            return estudante;
        }

        public void SetEstudante(string estudante)
        {
            this.estudante = estudante;
        }


        //Polimorfismo de sobrecarga
        public override void Visualizar()
        {
            base.Visualizar();

            Console.WriteLine($" É estudante: {this.estudante}");
            //metade do valor do ingresso (não funciona)

            if (this.estudante == "Sim")
            {
                Console.WriteLine($" Valor do ingresso com desconto: {this.GetValor() / 2}");
            }

        }
    }
}
