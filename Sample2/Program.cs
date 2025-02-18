using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Sample2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string nome = GetInput("Inserisci il tuo nome:");
            //string cognome = GetInput("Inserisci il tuo cognome:");

            //PrintFullName(nome, cognome);

            //int? num1 = GetNumber();
            //int? num2 = GetNumber();

            //if (num1 != null && num2 != null)
            //{
            //    var sum = Sum(num1.Value, num2.Value);
            //    Console.WriteLine($"La somma è {sum}");
            //}

            int numA = GetNumber("Add a number").Value;
            int numB = GetNumber("Add a number").Value;

            IncreaseByOne(ref numA, ref numB);
            IncreaseByOne(ref numA, ref numB);
            IncreaseByOne(ref numA, ref numB);
            IncreaseByOne(ref numA, ref numB);

            Console.WriteLine(numA);
            Console.WriteLine(numB);

            int sum = 109;

            GetSumAndDiff(numA, numB, out sum, out int diff);

            Console.WriteLine($"La somma è: {sum}");
            Console.WriteLine($"La differenza è: {diff}");

            Sum(numA, numB);
            Sum(numA, numB, numB);
            Sum(1, 2, 3, 54, 5435, 534, 32);
        }

        static string GetInput(string msg)
        {
            Console.WriteLine(msg);
            return Console.ReadLine();
        }

        static int? GetNumber(string msg = "Inserisci un numero intero:")
        {
            Console.WriteLine(msg);

            if (int.TryParse(Console.ReadLine(), out int number))
            {
                return number;
            }
            else
            {
                return null;
            }
        }

        static void PrintFullName(string firstName, string lastName)
        {
            Console.WriteLine($"{firstName} {lastName}");
        }

        static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }

        static int Sum(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }

        static int Sum(int num1, params int[] nums)
        {
            var sum = num1;

            foreach (var num in nums)
            {
                sum += num;
            }

            return sum;
        }

        static double Sum(double num1, double num2)
        {
            return num1 + num2;
        }

        static void IncreaseByOne(ref int number1, ref int number2)
        {
            number1++;
            number2++;
        }

        static void GetSumAndDiff(int num1, int num2, out int sum, out int diff)
        {
            sum = num1 + num2;
            diff = num1 - num2;
        }

    }
}
