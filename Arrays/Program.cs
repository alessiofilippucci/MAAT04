namespace MAAT04.Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declares an Array of integers.
            int[] numbers;

            // allocating memory for 5 integers.
            numbers = new int[5];

            // initialize the first elements of the array
            numbers[0] = 10;

            // initialize the second elements
            numbers[1] = 20;

            // so on...
            numbers[2] = 30;
            numbers[3] = 40;
            numbers[4] = 50;

            // Access the array elements using the index.
            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);
            Console.WriteLine(numbers[3]);
            Console.WriteLine(numbers[4]);

            // Declare and initialize an array of integers
            int[] numbers2 = new int[] { 10, 20, 30, 40, 50 };

            // accessing the elements
            // using for loop
            Console.Write("For loop :");
            for (int i = 0; i < numbers2.Length; i++)
                Console.Write(" " + numbers2[i]);

            Console.WriteLine("");
            Console.Write("For-each loop :");

            // using for-each loop
            foreach (int i in numbers2)
                Console.Write(" " + i);

            Console.WriteLine("");
            Console.Write("while loop :");

            // using while loop
            int j = 0;
            while (j < numbers2.Length)
            {
                Console.Write(" " + numbers2[j]);
                j++;
            }

            Console.WriteLine("");
            Console.Write("Do-while loop :");

            // using do-while loop
            int k = 0;
            do
            {
                Console.Write(" " + numbers2[k]);
                k++;
            } while (k < numbers2.Length);



            // declares a 1D Array of string.
            string[] weekDays;

            // allocating memory for days.
            weekDays = new string[] { 
                "Sun", 
                "Mon", 
                "Tue", 
                "Wed", 
                "Thu", 
                "Fri", 
                "Sat"
            };

            // Displaying Elements of array
            foreach (string day in weekDays)
                Console.Write(day + " ");


            // The same array with dimensions 
            // specified 2, 2 and 3.
            int[,,] arr = new int[2, 2, 3] { 
                { 
                    { 1, 2, 3 }, { 4, 5, 6 }
                }, 
                { 
                    { 7, 8, 9 }, { 10, 11, 12 }
                } 
            };

            // Checking elements at particular index
            Console.WriteLine("arr[1][0][1] : " + arr[1, 0, 1]);

            Console.WriteLine("arr[1][1][2] : " + arr[1, 1, 2]);


            // Declaring Jagged Array
            int[][] jaggedArr = new int[2][] { 
                new int[] { 1, 3, 5, 7, 9 }, 
                new int[] { 2, 4, 6, 8 } 
            };

            Console.WriteLine("Arrays :");

            // Display the array elements:
            for (int ii = 0; ii < jaggedArr.Length; ii++)
            {
                System.Console.Write("Elements[" + ii + "] Array: ");

                // Printing the elements of array
                for (int jj = 0; j < jaggedArr[ii].Length; j++)
                {
                    Console.Write(jaggedArr[ii][jj] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
