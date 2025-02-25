namespace Sample4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person pers = new Person();

            pers.FirstName = "Alessio";
            pers.LastName = "Filippucci";
            pers.Dob = new DateTime(1989, 6, 11);

            pers.DisplayFullname();

            var age = pers.GetAge();
            Console.WriteLine($"La tua età è di {age} anni");


            var pers1 = new Person("Alessio", "Filippucci", new DateTime(1989, 6, 11));

        }
    }
}
