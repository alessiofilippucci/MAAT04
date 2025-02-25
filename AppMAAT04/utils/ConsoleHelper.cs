namespace AppMAAT04.utils
{
    public static class ConsoleHelper
    {
        public static void LogInfo(string msg)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(msg);
        }

        public static void LogWarning(string msg)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(msg);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        public static void LogError(string msg)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(msg);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        public static string GetValue(string? msg = null)
        {
            if (!string.IsNullOrEmpty(msg))
            {
                LogInfo(msg);
            }
            return Console.ReadLine();
        }
    }
}
