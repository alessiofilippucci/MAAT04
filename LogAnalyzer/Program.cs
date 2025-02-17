namespace LogAnalyzer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var logFolder = "D:\\OneDrive\\LEZIONI\\ITS\\MAAT04\\projects\\MAAT04\\LogAnalyzer\\logs\\";
            
            var logFile = $"{logFolder}\\logs.txt";
            
            var logLines = File.ReadAllLines(logFile);

            var logInfos = new List<string>();
            var logWarnings = new List<string>();
            var logErrors = new List<string>();
            var logUnknown = new List<string>();

            foreach (var logLine in logLines)
            {
                var logParts = logLine.Split(',');

                var logData = logParts[0];
                var logError = logParts[1];
                var logMsg = logParts[2];

                switch (logError)
                {
                    case "Error":
                        {
                            logErrors.Add(logLine);
                            break;
                        }
                    case "Warning":
                        {
                            logWarnings.Add(logLine);
                            break;
                        }
                    case "Info":
                        {
                            logInfos.Add(logLine);
                            break;
                        }
                    default:
                        {
                            logUnknown.Add(logLine);
                            break;
                        }
                }
            }

            var infoLogFile = $"{logFolder}\\infos.txt";
            var warningsLogFile = $"{logFolder}\\warnings.txt";
            var errorsLogFile = $"{logFolder}\\errors.txt";
            var unknownLogFile = $"{logFolder}\\unknown.txt";

            File.WriteAllLines(infoLogFile, logInfos);
            File.WriteAllLines(warningsLogFile, logWarnings);
            File.WriteAllLines(errorsLogFile, logErrors);
            File.WriteAllLines(unknownLogFile, logUnknown);
        }
    }
}
