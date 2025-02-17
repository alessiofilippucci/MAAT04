namespace SortList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>();

            var input = "";

            do
            {
                Console.WriteLine("Inserisci un numero o q per uscire");
                input = Console.ReadLine();

                if (int.TryParse(input, out int number))
                {
                    numbers.Add(number);
                }
            }
            while (input != "q");

            numbers.Sort();

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
