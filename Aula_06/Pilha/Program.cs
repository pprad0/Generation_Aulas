namespace Pilha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<string> pilha = new Stack<string>();

            pilha.Push("Pedro");
            pilha.Push("João");
            pilha.Push("Rafael");
            pilha.Push("Gaspar");
            pilha.Push("Karina");
            pilha.Push("Thiago");

            pilha.Pop();

            foreach (var nome in pilha)
            {
                Console.WriteLine(nome);
            }

            Console.WriteLine($"\nQuem é o primeiro da pilha? {pilha.Peek()} ");
            Console.WriteLine($"\nThiago entrou na pilha? {pilha.Contains("Thiago")}");
            Console.WriteLine($"\nNúmero de pessoas na pilha: {pilha.Count()}\n");

        }
    }
}