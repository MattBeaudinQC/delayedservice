using System;
using System.Collections.Generic;
using System.Configuration;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Timers;

namespace longStartupService
{
    
    public partial class Service1 : ServiceBase
    {
       
        public Service1()
        {
            
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            


        }

        protected override void OnStop()
        {
            int int_stop_delay;
            int.TryParse(ConfigurationManager.AppSettings.Get("stopDelay"), out int_stop_delay);

            Thread.Sleep(int_stop_delay);

        }

       
    }
}
