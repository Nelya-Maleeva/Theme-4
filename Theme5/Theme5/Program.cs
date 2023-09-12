using System;
using System.IO;

namespace Theme5
{

    using System;
    using System.IO;
    using System.Text.RegularExpressions;
    class Program
    {
        static void Main(string[] args)
        {
            string readFile = "logs.txt";
            string addFile = "errors.log";

            double ratio = ExtractErrors(readFile, addFile);
            Console.WriteLine($"Ratio of errors to total log entries: {ratio}");
        }
        static double ExtractErrors(string readFile, string addFile)
        {
            int totalLogEntries = 0;
            int errorLogEntries = 0;
            try
            {
                using (StreamReader reader = new StreamReader(readFile))
                using (StreamWriter writer = new StreamWriter(addFile, true))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        totalLogEntries++;

                        if (line.Contains(("CRITICAL ERROR")))
                        {
                            Console.WriteLine(line);
                            throw new CustomException("CRITICAL ERROR found!");
                        }
                        else if (line.Contains("error") || line.Contains("Error") || line.Contains("ERROR"))
                        {
                            errorLogEntries++;
                            writer.WriteLine(line);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error!");
            }
            try
            {
                double ratio = (double)totalLogEntries / errorLogEntries;
                return ratio;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Division by zero error");
                return 0; 
            }
        }
        public class CustomException : Exception
        {
            public CustomException(string message) : base(message) { }
        }
    }
}



