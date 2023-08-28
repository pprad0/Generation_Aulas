namespace Lista01___Vetores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // --- Exercício 01 ---
            int[] vetor = { 2, 5, 1, 3, 4, 9, 7, 8, 10, 6 };
            int indexNumero = -1, numeroDigitado;
            string encontrado = "";


            Console.Write("Digite o número que você deseja encontrar: ");
            numeroDigitado = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < 10; i++)
            {
                if (vetor[i] == numeroDigitado)
                {
                    indexNumero = i;
                    break;
                }
            }

            encontrado = indexNumero < 0 ?
                 $"O número {numeroDigitado} não foi encontrado!"
                : $"O número {numeroDigitado} está localizado na posição: {indexNumero}. ";

            Console.WriteLine(encontrado);



            // --- Exercício 02 ---
            int tamanhoVetor = 0;

            Console.Write("Qual será o tamanho do vetor ? ");
            tamanhoVetor = Convert.ToInt32(Console.ReadLine());


            int[] vetor2 = new int[tamanhoVetor];

            int ordemNumero = 1, indiceNumero = 0;
            string elementosIndicesImpares = "", elementosPares = "";
            double soma = 0, media;

            do
            {
                Console.Write($"Digite o {ordemNumero}º número: ");
                vetor2[indiceNumero] = Convert.ToInt32(Console.ReadLine());

                indiceNumero++;
                ordemNumero++;

            } while (ordemNumero <= vetor2.Length);


            for (int j = 0; j < tamanhoVetor; j++)
            {
                if (j % 2 == 1)
                    elementosIndicesImpares += $"{vetor2[j]} ";

                if (vetor2[j] % 2 == 0)
                    elementosPares += $"{vetor2[j]} ";

                soma += vetor2[j];
            }

            media = soma / tamanhoVetor;

            Console.WriteLine($"Elementos nos índices ímpares: {elementosIndicesImpares} \r\nElementos pares: {elementosPares} \r\nSoma: {soma} \r\nMédia: {media} ");

        }
    }
}