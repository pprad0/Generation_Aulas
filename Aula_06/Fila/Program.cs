namespace Fila
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> fila = new Queue<string>();

            fila.Enqueue("Pedro");
            fila.Enqueue("João");
            fila.Enqueue("Rafael");
            fila.Enqueue("Gaspar");
            fila.Enqueue("Karina");
            fila.Enqueue("Thiago");

            fila.Dequeue();

            foreach (var nome in fila)
            {
                Console.WriteLine(nome);
            }

            Console.WriteLine($"\nQuem é o primeiro da fila? {fila.Peek()} ");
            Console.WriteLine($"\nThiago entrou na fila? {fila.Contains("Thiago")}");
            Console.WriteLine($"\nNúmero de pessoas na fila: {fila.Count()}\n");


        }
    }
}