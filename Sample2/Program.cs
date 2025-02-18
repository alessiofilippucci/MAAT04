namespace Sample2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            string nome = GetFirstName();
            string cognome = GetLastName();

            PrintFullName(nome, cognome);
        }

        static string GetFirstName()
        {
            Console.WriteLine("Inserisci il tuo nome:");
            return Console.ReadLine();
        }

        static string GetLastName()
        {
            Console.WriteLine("Inserisci il tuo cognome:");
            return Console.ReadLine();
        }

        static void PrintFullName(string firstName, string lastName)
        {
            Console.WriteLine($"{firstName} {lastName}");
        }
    }
}
