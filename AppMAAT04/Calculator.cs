using AppMAAT04.utils;

namespace AppMAAT04
{
    public class Calculator
    {
        string[] allowedOp = { "+", "-", "*", "/" };

        int num1;
        int num2;
        string op = "";

        public void Start()
        {
            num1 = NumberHelper.GetNumber();
            num2 = NumberHelper.GetNumber();

            GetOperator();
        }


        void GetOperator()
        {
            op = "";

            ConsoleHelper.LogInfo(string.Format("Scegli tra {0}", string.Join(",", allowedOp)));

            while (!allowedOp.Contains(op))
            {
                op = ConsoleHelper.GetValue();
            }
        }
    }
}
