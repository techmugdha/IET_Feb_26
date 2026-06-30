namespace _08Demo_Filters_Session.Loggers
{
    public class Logger
    {
        private static readonly Logger _logger = new Logger();
        private Logger()
        {
            
        }

        public static Logger CurrentLogger 
        {
            get { return _logger; }
        }

        public void Log(string message) 
        {
            string filePath = @"D:\2026\DotNet\IET_Feb_26\WebDemos26\08Demo_Filters_Session\FileLogs\applog.txt";

            FileStream fs = null;

            if (File.Exists(filePath))
            {
                fs = new FileStream(filePath, FileMode.Append, FileAccess.Write);
            }
            else
            {
                fs = new FileStream(filePath,FileMode.Create,FileAccess.Write);
            }

            StreamWriter writer = new StreamWriter(fs);
            writer.Write($"Logged at {DateTime.Now.ToString()}: {message}");

            writer.Close();
            fs.Close();

            writer = null;
            fs = null;
        }
    }
}
