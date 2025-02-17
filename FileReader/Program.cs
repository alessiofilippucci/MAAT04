namespace LogReader
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SAMPLE CODE

            string folder = "D:\\OneDrive\\LEZIONI\\ITS\\MAAT04\\projects\\MAAT04\\LogReader\\";

            var lines = File.ReadAllLines($"{folder}\\test.txt");

            var outputLines = new List<string>();

            foreach (var line in lines)
            {
                var splittedLine = line.Split(";");

                string country = splittedLine[0];
                string capital = splittedLine[1];

                if (string.IsNullOrEmpty(country))
                {
                    Console.WriteLine($"Manca il paese");
                }
                else
                {
                    var msg = $"La capitale di {country} è {capital}";
                    Console.WriteLine(msg);
                    outputLines.Add(msg);
                }
            }

            string outputFile = $"{folder}\\output.txt";

            File.WriteAllLines(outputFile, outputLines);

        }
    }
}
