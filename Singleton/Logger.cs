namespace Singleton
{
    public class Logger
    {
        // Private static readonly instance, using Lazy<T> for lazy initialization
        private static readonly Lazy<Logger> _instance = new(() => new Logger());

        // Private constructor to prevent instantiation from outside
        private Logger() 
        {
            Console.WriteLine("Logger instance created.");
        }

        // Public property to access the instance
        public static Logger Instance => _instance.Value;

        // Log method
        public void Log(string message)
        {
            Console.WriteLine($"Log: {message}");
        }
    }
}
