using NLog;
using NLog.Config;
using NLog.Layouts;
using NLog.Targets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogSystem.Classes
{
    class LogDemo
    {
        // ********************************************************************

        public void SimpleLog()
        {
            var logFileName = "simplelog";
            var log = LogManager.GetLogger(logFileName);
            int i = 0;
            try
            {
                var j = 10 / i;
            }
            catch (Exception e)
            {
                var customMessage = "Division by zero";
                log.Error(e, customMessage);
            }
        }

        // ********************************************************************

        public void DynamicLog()
        {
            // prepare the logger
            var config = LogManager.Configuration;
            var fileTarget = new FileTarget();
            config.AddTarget("Dynamic", fileTarget);

            fileTarget.FileName = "${basedir}/Logs/${logger}.log";
            fileTarget.ArchiveFileName = "${basedir}Logs/Archives/${logger}.{#}.zip";
            fileTarget.EnableArchiveFileCompression = true;
            fileTarget.ArchiveOldFileOnStartup = false;
            fileTarget.DeleteOldFileOnStartup = false;
            fileTarget.AutoFlush = true;
            fileTarget.ArchiveEvery = FileArchivePeriod.Day;
            fileTarget.ArchiveNumbering = ArchiveNumberingMode.Rolling;
            fileTarget.MaxArchiveFiles = 90;
            fileTarget.ConcurrentWrites = true;
            fileTarget.KeepFileOpen = true;

            // define JSON structure
            var jsonLayout = new JsonLayout();
            jsonLayout.IncludeAllProperties = false;
            jsonLayout.Attributes.Add(new JsonAttribute("time", "${longdate}"));
            jsonLayout.Attributes.Add(new JsonAttribute("GC0_count", "${event-properties:item=GC0_count}"));
            // annyi json attributuomot adsz hozzá amennyit csak akarsz

            fileTarget.Layout = jsonLayout;
            var rule = new LoggingRule("Dynamic", LogLevel.Info, fileTarget);
            config.LoggingRules.Add(rule);

            LogManager.Configuration = config;

            // fill the GC0_count property with value
            var logEventInfo = new LogEventInfo(LogLevel.Trace, "DynamicLog", "");
            logEventInfo.Properties["GC0_count"] = GC.CollectionCount(0);

            // create the logger, and write the JSON
            var dynamicLogger = LogManager.GetLogger("DynamicLog");
            dynamicLogger.Log(LogLevel.Info, logEventInfo);
        }
    }
}
