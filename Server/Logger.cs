using System;

namespace DOP.Remoting
{
    public class Logger : System.MarshalByRefObject, ILogger
    {
        private int m_level = 1;
        private static int messageCount = 0;

        public Logger()
        {
            // netreba messageCount resetat kao sto sam inicijano radila
        }

        public void SetLevel(int level)
        {
            m_level = level;
        }

        public void LogMessage(int level, string message)
        {
            if (level >= m_level)
            {
                Console.WriteLine($"{message} [{++messageCount}]");
            }
        }
    }
}

