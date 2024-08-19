using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AYRUZ_YATT
{
    internal class Logger
    {
        private readonly log4net.ILog log_ = log4net.LogManager.GetLogger("RollingErrorLogFileAppender");
        public static log4net.ILog log = Instance.log_;

        private static Logger? Works;
        private static Logger Instance
        {
            get
            {

                var logRepository = log4net.LogManager.GetRepository(Assembly.GetEntryAssembly());
                log4net.Config.XmlConfigurator.Configure(logRepository, new FileInfo("Folder_Configs\\log4net.config"));
                Works ??= new Logger();
                return Works;
            }
        }
    }
}
