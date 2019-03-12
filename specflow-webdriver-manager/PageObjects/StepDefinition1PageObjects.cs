using OpenQA.Selenium;
using specflow_webdriver_manager.WebDrivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace specflow_webdriver_manager.PageObjects
{
    [Binding]
    public class StepDefinition1PageObjects
    {
        private WebDriverManager _webDriverManager;

        public StepDefinition1PageObjects(WebDriverManager webDriverManager)
        {
            _webDriverManager = webDriverManager;
        }

        private const string LINK_NAME = "li.av-menu-button";

        public void GetUrl(string url)
        {
            _webDriverManager.Driver().Navigate().GoToUrl(url);
        }

        public bool GetPageUrlName(string pageUrl)
        {
            return _webDriverManager.Driver().Url.Equals(pageUrl);
        }

        public void ClickLink()
        {
            _webDriverManager.Driver().FindElement(By.CssSelector(LINK_NAME)).Click();
        }
    }
}
