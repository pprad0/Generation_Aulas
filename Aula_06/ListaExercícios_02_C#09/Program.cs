namespace ListaExercícios_02_C_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<string> pilha = new Stack<string>();

            string menu =
                "\n1 - Adicionar livro na pilha" +
                "\n2 - Listar todos os livros" +
                "\n3 - Retirar livro da pilha" +
                "\n0 - Sair";

            int numeroDigitado;
            string? livro;
            while (true)
            {
                Console.WriteLine(menu);
                Console.Write("\nEntre com a opção desejada: ");
                numeroDigitado = Convert.ToInt32(Console.ReadLine());

                if (numeroDigitado == 1)
                {
                    Console.Write("\nDigite o nome do livro: ");
                    livro = Console.ReadLine()!;
                    pilha.Push(livro);

                    Console.Write("Pilha: ");
                    foreach (var i in pilha)
                        Console.WriteLine(i);

                    Console.Write("\nLivro adicionado!\n\n");
                }


                else if (numeroDigitado == 2)
                {
                    if (pilha.Count() > 0)
                    {
                        Console.WriteLine("\nLista de livros na pilha:\n");
                        foreach (var i in pilha)
                            Console.WriteLine(i);
                    }
                    else
                        Console.WriteLine("\nA pilha está vazia. \n");
                }


                else if (numeroDigitado == 3)
                {
                    if (pilha.Count() > 0)
                    {
                        pilha.Pop();
                        Console.WriteLine("\nPilha: \n");
                        foreach (var i in pilha)
                            Console.WriteLine(i);

                        Console.WriteLine("\nUm livro foi retirado da pilha! \n");
                    }
                    else
                        Console.WriteLine("\nA pilha está vazia. \n");
                }

                else if (numeroDigitado == 0)
                    break;
            }

            Console.WriteLine("\n\nVolte sempre!\n\n");

        }
    }
}