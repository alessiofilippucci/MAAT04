namespace Sample4
{
    public class Person
    {
        public string FirstName;
        public string LastName;
        public DateTime Dob;

        public Person()
        {
        }

        public Person(string firstName, string lastName, DateTime dob)
        {
            FirstName = firstName;
            LastName = lastName;
            Dob = dob;
        }

        public int GetAge()
        {
            var age = DateTime.Now.Year - Dob.Year;

            if (DateTime.Now > Dob)
            {
                age--;
            }

            return age;
        }

        public void DisplayFullname()
        {
            Console.WriteLine($"{FirstName} {LastName}");
        }

        public void DisplayFirstName()
        {
            Console.WriteLine($"{FirstName}");
        }

        public void DisplayLastName()
        {
            Console.WriteLine($"{LastName}");
        }

    }
}
