namespace Lista02___Matrizes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // --- Exercício 03 ---

            int[,] matriz = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            string diagonalPrincipal = $"{matriz[0, 0]} {matriz[1, 1]} {matriz[2, 2]}";
            string diagonalSecundaria = $"{matriz[0, 2]} {matriz[1, 1]} {matriz[2, 0]}";

            int somaPrincipal = matriz[0, 0] + matriz[1, 1] + matriz[2, 2];
            int somaSecundaria = matriz[0, 2] + matriz[1, 1] + matriz[2, 0];


            Console.WriteLine($"Elementos da Diagonal Principal: {diagonalPrincipal} \r\nElementos da Diagonal Secundária: {diagonalSecundaria}");
            Console.WriteLine($"Soma dos Elementos da Diagonal Principal: {somaPrincipal} \r\nSoma dos Elementos da Diagonal Segundária: {somaSecundaria}");



            // --- Exercício 04 ---

            int[,] matriz2 = new int[4, 10];

            double mediaParticipante = 0;


            foreach (int i in matriz2)
            {

            }





        }
    }
}