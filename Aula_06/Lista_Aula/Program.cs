namespace Lista_Aula
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> notas = new List<double>();

            notas.Add(1.2);
            notas.Add(5.2);
            notas.Add(7.45);
            notas.Add(9.4);
            notas.Add(4.2);

            notas.Sort();

            foreach (double nota in notas)
            {
                Console.WriteLine($"Nota: {nota}");
            }

            Console.WriteLine($"Index da nota 9.4: {notas.IndexOf(9.4)}");
            Console.WriteLine($"Contém a nota 5.2 ? {notas.Contains(5.2)}");
            Console.WriteLine($"Contagem:  {notas.Count()}");

        }
    }
}