namespace Lista_01_C_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // --- Exercício 01 ---
            List<string> lista = new List<string>();
            string? cor;

            for (int index = 0; index < 5; index++)
            {
                Console.Write("Digite uma cor: ");
                cor = Console.ReadLine()!;
                lista.Add(cor);
            }


            Console.WriteLine("\nLista de todas as cores: ");

            foreach (string item in lista)
                Console.WriteLine(item);


            Console.WriteLine("\nLista de todas as cores ordenadas A-Z: ");
            lista.Sort();

            foreach (string item in lista)
                Console.WriteLine(item);


            // --- Exercício 02 ---

            List<int> list = new List<int>();
            int numeroDigitado;
            string frase;

            list.Add(2);
            list.Add(5);
            list.Add(1);
            list.Add(3);
            list.Add(4);
            list.Add(9);
            list.Add(7);
            list.Add(8);
            list.Add(10);
            list.Add(6);

            Console.Write("Digite o número que você deseja encontrar: ");
            numeroDigitado = Convert.ToInt32(Console.ReadLine());

            frase = list.IndexOf(numeroDigitado) >= 0
                ? $"\nO número {numeroDigitado} está localizado na posição: {list.IndexOf(numeroDigitado)}"
                : $"O número {numeroDigitado} não foi encontrado!";

            Console.WriteLine(frase);
        }
    }
}