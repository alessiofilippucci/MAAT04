using System.Collections.Immutable;

namespace LogAnalyzer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var logFolder = "D:\\OneDrive\\LEZIONI\\ITS\\MAAT04\\projects\\MAAT04\\LogAnalyzer\\data\\";
            
            var logFile = $"{logFolder}\\logs.txt";
            
            var logLines = File.ReadAllLines(logFile);

            var logInfos = new List<string>();
            var logWarnings = new List<string>();
            var logErrors = new List<string>();
            var logUnknown = new List<string>();

            foreach (var logLine in logLines.OrderDescending())
            {
                var logParts = logLine.Split(',');

                var logData = logParts[0];
                var logType = logParts[1];
                var logMsg = logParts[2];

                var logOutput = $"{logData}: {logMsg}";

                switch (logType)
                {
                    case "Error":
                        {
                            logErrors.Add(logOutput);
                            break;
                        }
                    case "Warning":
                        {
                            logWarnings.Add(logOutput);
                            break;
                        }
                    case "Info":
                        {
                            logInfos.Add(logOutput);
                            break;
                        }
                    default:
                        {
                            logUnknown.Add(logOutput);
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
