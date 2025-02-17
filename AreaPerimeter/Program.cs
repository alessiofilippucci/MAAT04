namespace AreaPerimeter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Find the Area and Perimeter of a Rectangle :");
            Console.WriteLine("-------------------------------------------------");

            Console.Write("Input the width of the rectangle : ");
            int width = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the height of the rectangle : ");
            int height = Convert.ToInt32(Console.ReadLine());

            int area = width * height;
            int perimeter = 2 * (width + height);

            Console.WriteLine($"The area of the rectangle is : {area}");
            Console.WriteLine($"The perimeter of the rectangle is : {perimeter}");

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (j == 0 || i == 0 || i == height - 1 || j == width - 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine("");
            }
        }
    }
}
