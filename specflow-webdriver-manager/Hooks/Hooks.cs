using specflow_webdriver_manager.WebDrivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace specflow_webdriver_manager.Hooks
{
    [Binding]
    public sealed class Hooks
    {
        private WebDriverManager _webDriverManager;

        public Hooks(WebDriverManager webDriverManager)
        {
            _webDriverManager = webDriverManager;
        }

        [BeforeScenario]
        public void TestFixtureSetUp()
        {
            _webDriverManager.GetDriver();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            _webDriverManager.CloseBrowser();
        }

        [AfterTestRun]
        public static void AfterTestRun()
        {
            KillIEDriver.CloseIEBrowser();
        }

    }
}
