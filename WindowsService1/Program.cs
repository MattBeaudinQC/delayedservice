using System;
using System.Configuration;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.ServiceProcess;
using System.Timers;
using System.Text;
using System.Threading;

namespace longStartupService
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 

        static void Main()
        {
            int int_delay;
            int.TryParse(ConfigurationManager.AppSettings.Get("startDelay"),out int_delay);
            
            Thread.Sleep(int_delay);

            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[]
            {

                new Service1()
            };
            ServiceBase.Run(ServicesToRun);
        }
    }
}
