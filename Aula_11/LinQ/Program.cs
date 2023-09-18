namespace LinQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<string> nomes = new List<string>() { "João", "Breno", "Julia", "Samantha", "Victor", "Vitor", "Vitor", "Matheus", "Mateus", "Karina" };


            var numerosAoCubo = numeros.Select(n => Math.Pow(n, 3));
            Console.WriteLine("Números ao cubo" + string.Join(", ", numerosAoCubo));
            //numerosAoCubo.ToList().ForEach(numero => Console.WriteLine(numero));

            var numerosImpares = from numero in numeros
                                 where numero % 2 != 0
                                 select (numero);

            Console.WriteLine("Números ímpares: " + string.Join(", ", numerosImpares));

            var nomesIniciamMV = from nome in nomes
                                 where nome.StartsWith("M") ||
                                       nome.StartsWith("V")
                                 select nome;

            //var numerosOrdemAscendente = ;
            //var numerosOrdemDescendente = ;
            //var nomesSemDuplicidade = ;
            //var contarVitors = ;

        }
    }
}