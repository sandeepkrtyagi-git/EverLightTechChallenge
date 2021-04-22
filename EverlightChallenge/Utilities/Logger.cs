using System;

namespace EverlightChallenge.Utilities
{
    public class Logger : ILogger
    {
        public void EndApplication()
        {
            Console.WriteLine("Application Finished");
        }

        public void Log(string message)
        {
            Console.WriteLine(message);
        }

        public void StartApplication()
        {
            Console.WriteLine("Application Staring");
        }
    }
}
