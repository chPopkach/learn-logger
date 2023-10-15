namespace LoggerLearn
{
    public class DBLogger : LogBase
    {
        string connectionString = string.Empty;
        public override void Log(string message)
        {
            lock (lockObj)
            {
                //Code to log data to the database
            }
        }
    }
}
