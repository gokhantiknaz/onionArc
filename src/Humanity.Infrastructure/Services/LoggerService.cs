﻿using Humanity.Application.Core.Services;
using NLog;
using NLog.Web;

namespace Humanity.Infrastructure.Services
{
    public class LoggerService : ILoggerService
    {
        // Create nlog.config (lowercase all) file in the root of your project
        
        public NLog.Logger  logger = NLog.LogManager.Setup().LoadConfigurationFromAppSettings().GetCurrentClassLogger();
        

        public void LogError(string errorMessage)
        {
            logger.Error(errorMessage);
        }

        public void LogError(string errorMessage, params object[] args)
        {
            logger.Error(errorMessage, args);
        }

        public void LogException(Exception ex)
        {
            logger.Error(ex);
        }

        public void LogInfo(string infoMessage)
        {
            logger.Info(infoMessage);
        }

        public void LogInfo(string infoMessage, params object[] args)
        {
            logger.Info(infoMessage, args);
        }
    }
}
