using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AddingStuffAndChecking
{
    public class LogNLog : ICezLog
    {
        private static readonly NLog.ILogger logger = LogManager.GetCurrentClassLogger();

        public LogNLog()
        {
        }

        public void Info(string message)
        {
            logger.Info(message);
        }

        public void Warn(string message)
        {
            logger.Warn(message);
        }

        public void Debug(string message)
        {
            logger.Debug(message);
        }

        public void Error(Exception exp)
        {
            logger.Error(exp);
        }

        public void Error(string message)
        {
            logger.Error(message);
        }
    }

    public interface ICezLog
    {
        void Info(string message);
        void Warn(string message);
        void Debug(string message);
        void Error(string message);
        void Error(Exception exp);
    }


}
