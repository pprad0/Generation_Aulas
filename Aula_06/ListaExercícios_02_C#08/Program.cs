namespace ListaExercícios_02_C_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // --- Exercício 03 ---
            HashSet<int> setHash = new HashSet<int>();
            int numeroDigitado;

            for (int index = 0; index < 10; index++)
            {
                Console.Write("Digite um número: ");
                numeroDigitado = Convert.ToInt32(Console.ReadLine());
                setHash.Add(numeroDigitado);
            }

            Console.WriteLine($"\nListagem dos números sem repetir: ");
            foreach (var numero in setHash)
                Console.WriteLine(numero);



            // --- Exercício 03 ---
            HashSet<int> hash = new HashSet<int>();
            int num;
            string frase = "";

            hash.Add(2);
            hash.Add(5);
            hash.Add(1);
            hash.Add(3);
            hash.Add(4);
            hash.Add(9);
            hash.Add(7);
            hash.Add(8);
            hash.Add(10);
            hash.Add(6);

            Console.Write("Digite o número que você deseja encontrar: ");
            num = Convert.ToInt32(Console.ReadLine());

            foreach (var i in hash)
            {
                if (i == num)
                {
                    frase = $"O número {num} foi encontrado!";
                    break;
                }

                else
                    frase = $"O número {num} não foi encontrado!";

            }

            Console.WriteLine(frase);
        }
    }
}