namespace Hash
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> setNomes = new HashSet<string>();

            setNomes.Add("Pedro");
            setNomes.Add("Lucas");
            setNomes.Add("Diegão");
            setNomes.Add("Leo");

            setNomes.Remove("Leo");
            setNomes.Reverse(); //não funciona, assim como o Sort, pois não possui índice.

            List<string> hashList = setNomes.ToList(); //agora é ordenável
            hashList.Reverse();


            foreach (var i in setNomes)
            {
                Console.WriteLine($"Nome: {i}");
            }

            Console.WriteLine("\nDepois de ter transformado HashSet para HashList: \n");

            foreach (var i in hashList)
            {
                Console.WriteLine($"Nome: {i}");
            }

            Console.WriteLine($"\nNome Julia existe ? {setNomes.Contains("Julia")}\n");

        }
    }
}