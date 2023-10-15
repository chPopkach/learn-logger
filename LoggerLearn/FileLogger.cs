﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerLearn
{
    public class FileLogger : LogBase
    {
        private string filePath = @"LogFile.txt";

        public override void Log(string message)
        {
            lock (lockObj)
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.WriteLine(message);
                    writer.Close();
                }
            }
        }
    }
}
