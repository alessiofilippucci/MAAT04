namespace AppMAAT04.utils
{
    public static class NumberHelper
    {
        public static int GetNumber()
        {
            ConsoleHelper.LogInfo("Inserisci un numero intero");
            if (!int.TryParse(Console.ReadLine(), out int num))
            {
                ConsoleHelper.LogWarning("Numero non valido!");
                return GetNumber();
            }
            return num;
        }
    }
}
