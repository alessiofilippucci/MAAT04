namespace Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // default constructor creates an empty list
            List<int> list = new List<int>();
            list.Add(10);
            list.Add(20);
            Console.WriteLine("Default Constructor: ");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            // Construnctors from IEnumerable
            int[] num = { 10, 20 };
            List<int> enumerableList = new List<int>(num);
            Console.WriteLine("Constructor with IEnumerable: ");
            foreach (var item in enumerableList)
            {
                Console.WriteLine(item);
            }

            // Constructor with Initial Capacity 
            List<int> cList = new List<int>(2);
            cList.Add(10);
            cList.Add(20);
            Console.WriteLine("Constructor with Initial Capacity: ");
            foreach (var item in cList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
