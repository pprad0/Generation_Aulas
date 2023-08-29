namespace ListaExercicios_01_C_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> fila = new Queue<string>();

            //1: Adicionar um novo Cliente na fila. Deve solicitar o nome do Cliente.
            //2: Listar todos os Clientes na fila
            //3: Chamar(retirar) uma pessoa da fila
            //0: O programa deve ser finalizado.

            string menu =
                "\n1 - Adicionar cliente na fila" +
                "\n2 - Listar todos os clientes" +
                "\n3 - Retirar cliente da fila" +
                "\n0 - Sair";

            int numeroDigitado;
            string? nome;


            while (true)
            {
                Console.WriteLine(menu);
                Console.Write("\nDigite a opção desejada: ");
                numeroDigitado = Convert.ToInt32(Console.ReadLine());

                if (numeroDigitado == 1)
                {
                    Console.Write("Digite seu nome: ");
                    nome = Console.ReadLine()!;
                    fila.Enqueue(nome);
                    Console.Write("\nAdicionado à fila!\n ");
                }

                if (numeroDigitado == 2)
                {
                    if (fila.Count > 0)
                    {
                        Console.WriteLine($"\nFila:\n");

                        foreach (var pessoa in fila)
                        {
                            Console.WriteLine(pessoa);
                        }


                    }
                    else
                        Console.WriteLine("\nA fila está vazia.\n");
                }

                if (numeroDigitado == 3)
                {
                    if (fila.Count() != 0)
                    {
                        Console.WriteLine($"\nPróximo da fila: {fila.Peek()}");
                        fila.Dequeue();
                        Console.WriteLine("O cliente foi chamado!\n");

                    }

                    else
                        Console.WriteLine("\nA fila está vazia.\n");
                }

                if (numeroDigitado == 0)
                    break;

            }

            Console.WriteLine("\n\nVolte sempre!\n\n");

        }
    }
}