namespace Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // default constructor creates an empty list
            var list = new List<int> { 1, 45, 78, 56 };
            list.Add(10);
            list.Add(20);
            
            Console.WriteLine("Default Constructor: ");
            
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            string.Join(",", list);

            //for (var i = 0; i < list.Count; i++)
            //{
            //    Console.WriteLine(list[i]);
            //    Console.WriteLine(list.ElementAt(i));
            //}

            // Construnctors from IEnumerable
            int[] num = { 10, 20 };
            var enumerableList = new List<int>(num);
            Console.WriteLine("Constructor with IEnumerable: ");
            foreach (var item in enumerableList)
            {
                Console.WriteLine(item);
            }

            // Constructor with Initial Capacity 
            var cList = new List<int>(2);
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
