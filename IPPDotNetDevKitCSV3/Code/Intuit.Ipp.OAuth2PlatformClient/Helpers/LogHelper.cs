﻿using System;
using System.Collections.Generic;
using System.Text;
using Intuit.Ipp.Core.Rest;


namespace Intuit.Ipp.OAuth2PlatformClient
{ 
    /// <summary>
    /// Helper class for advanced logger/serilogger
    /// </summary>
    public static class LogHelper
    {
        

        /// <summary>
        /// Gets the Request Response Logging mechanism for advanced logging using serilog.
        /// </summary>
        /// <returns>Returns value which specifies the request response logging mechanism.</returns>
        public static AdvancedLogging GetAdvancedLogging(bool enableSerilogRequestResponseLoggingForDebug,bool enableSerilogRequestResponseLoggingForTrace, bool enableSerilogRequestResponseLoggingForConsole, bool enableSerilogRequestResponseLoggingForRollingFile,string serviceRequestLoggingLocationForFile)
        {
            AdvancedLogging advancedLogger;
            advancedLogger = new AdvancedLogging(enableSerilogRequestResponseLoggingForDebug: enableSerilogRequestResponseLoggingForDebug, enableSerilogRequestResponseLoggingForTrace: enableSerilogRequestResponseLoggingForTrace, enableSerilogRequestResponseLoggingForConsole: enableSerilogRequestResponseLoggingForConsole, enableSerilogRequestResponseLoggingForRollingFile: enableSerilogRequestResponseLoggingForRollingFile, serviceRequestLoggingLocationForFile: serviceRequestLoggingLocationForFile);

            return advancedLogger;

        }
    }
}