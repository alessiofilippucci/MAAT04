namespace Sample2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            string _firstName = GetFirstName();
            string _lastName = GetLastName();

            PrintFullName(_firstName, _lastName);
        }

        static string GetFirstName()
        {

        }
        static string GetLastName()
        {

        }

        static void PrintFullName(string firstName, string lastName)
        {
            Console.WriteLine($"{firstName} {lastName}");
        }
    }
}
