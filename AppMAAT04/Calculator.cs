namespace AppMAAT04
{
    public class Calculator
    {
        string[] allowedOp = { "+", "-", "*", "/" };

        int num1;
        int num2;

        string op;

        public void Start()
        {
            num1 = GetNumber();
            num2 = GetNumber();

            GetOperator();
        }

        private int GetNumber()
        {
            Console.WriteLine("Inserisci un numero intero");
            if (!int.TryParse(Console.ReadLine(), out int num))
            {
                Console.WriteLine("Numero non valido!");
                return GetNumber();
            }
            return num;
        }

        void GetOperator()
        {
            op = "";

            while (!allowedOp.Contains(op))
            {
                Console.WriteLine("Scegli tra {0}", string.Join(",", allowedOp));
                op = Console.ReadLine();
            }
        }
    }
}
