using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using TechTalk.SpecFlow;

namespace specflow_webdriver_manager.WebDrivers
{
    [Binding]
    public class WebDriverManager
    {
        private IWebDriver webDriver;

        public IWebDriver Driver()
        {
            return webDriver;
        }

        public IWebDriver GetDriver()
        {
            var browserType = TestContext.Parameters["BROWSER"];
            switch (browserType)
            {
                case "CHROME":
                    webDriver = new ChromeDriver();
                    break;

                case "CHROMEHEADLESS":
                    ChromeOptions chromeOptions = new ChromeOptions();
                    chromeOptions.AddArguments("headless");
                    webDriver = new ChromeDriver(chromeOptions);
                    break;

                case "INTERNETEXPLORER":
                    webDriver = new InternetExplorerDriver();
                    break;

                case "FIREFOX":
                    webDriver = new FirefoxDriver();
                    break;

                case "FFHEADLESS":
                    FirefoxOptions firefoxOptions = new FirefoxOptions();
                    firefoxOptions.AddArguments("--headless");
                    webDriver = new FirefoxDriver(firefoxOptions);
                    break;

                default:
                    webDriver = new ChromeDriver();
                    break;
            }
            return webDriver;
        }

        public void CloseBrowser()
        {
            webDriver.Close();
            webDriver.Dispose();
        }

    }
}
