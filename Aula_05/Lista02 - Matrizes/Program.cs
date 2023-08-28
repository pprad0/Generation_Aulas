namespace Lista02___Matrizes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // --- Exercício 03 ---

            int[,] matriz = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            string diagonalPrincipal = "Os elementos da diagonal principal são ";
            string diagonalSecundaria = "Os elementos da diagonal secundária são ";

            for (int indiceLinha = 0; indiceLinha < matriz.GetLength(0); indiceLinha++)
            {
                for (int indiceColuna = 0; indiceColuna < matriz.GetLength(1); indiceColuna++)
                {
                    int elemento = matriz[indiceLinha, indiceColuna];
                    if (indiceLinha == indiceColuna)
                        diagonalPrincipal += $"{elemento} ";
                }

                for (int indiceColuna = 0; indiceColuna < matriz.GetLength(0); indiceColuna++)
                {
                    int elemento = matriz[matriz.GetLength(1) - 1 - indiceColuna, indiceLinha];
                    if (indiceLinha == indiceColuna)
                        diagonalSecundaria += $"{elemento} ";
                }

            }
            Console.WriteLine($"{diagonalPrincipal} \r\n{diagonalSecundaria}");
            //Console.WriteLine($"Soma dos Elementos da Diagonal Principal: {somaPrincipal} \r\nSoma dos Elementos da Diagonal Segundária: {somaSecundaria}");



            // --- Exercício 04 ---

            double[,] matriz2 = { { 4.0, 5.0, 7.0, 3.0 }, { 2.5, 6.5, 4.7, 8.0 }, { 10.0, 8.5, 9.5, 8.0 }, { 9.0, 6.5, 7.6, 8.2 }, { 5.0, 5.0, 5.0, 6.3 }, { 7.0, 8.0, 9.0, 8.5 }, { 5.5, 3.5, 2.5, 1.0 }, { 8.0, 9.0, 10.0, 9.5 }, { 5.6, 5.8, 6.5, 7.0 }, { 7.5, 8.5, 9.5, 10.0 } };


            double nota1 = 0, nota2 = 0, nota3 = 0, nota4 = 0;
            double mediaParticipante, somatoriaNotas = 0;
            int contador1a4 = 1;


            foreach (double j in matriz2)
            {
                somatoriaNotas += j;

                if (contador1a4 == 4)
                {
                    nota4 = j;
                    contador1a4 = 0;
                    mediaParticipante = Math.Round((nota1 + nota2 + nota3 + nota4) / 4, 1);
                    Console.WriteLine($"A media deste participante é: {mediaParticipante} ");
                }
                if (contador1a4 == 1)
                    nota1 = j;
                else if (contador1a4 == 2)
                    nota2 = j;
                else if (contador1a4 == 3)
                    nota3 = j;

                contador1a4++;
            }



        }
    }
}