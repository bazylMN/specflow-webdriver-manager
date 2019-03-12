using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace specflow_webdriver_manager.WebDrivers
{
    [Binding]
    public class KillIEDriver
    {

        public static void CloseIEBrowser()
        {
            Process[] processlist = Process.GetProcesses();
            string ieServer = "IEDriverServer";
            string ie = "iexplore";

            foreach (Process theprocess in processlist)
            {
                if (theprocess.ProcessName == ieServer)
                {
                    theprocess.Kill();
                }

                if (theprocess.ProcessName == ie)
                {
                    theprocess.Kill();
                }
            }
        }

    }
}
