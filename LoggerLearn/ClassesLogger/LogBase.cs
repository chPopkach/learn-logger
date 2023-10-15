﻿namespace LoggerLearn
{
    public enum LogTarget
    {
        File, Database, EventLog
    }

    public abstract class LogBase
    {
        protected readonly object lockObj = new object();
        public abstract void Log(string message);
    }
}
