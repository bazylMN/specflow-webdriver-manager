using specflow_webdriver_manager.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace specflow_webdriver_manager.Assertions
{
    [Binding]
    public class StepDefinition1Assertions
    {
        private StepDefinition1PageObjects _stepDefinition1PageObjects;

        public StepDefinition1Assertions(StepDefinition1PageObjects stepDefinition1PageObjects)
        {
            _stepDefinition1PageObjects = stepDefinition1PageObjects;
        }

        public void AssertPageUrlName(string pageUrl)
        {
            Assert.IsTrue(_stepDefinition1PageObjects.GetPageUrlName(pageUrl));
        }

    }
}
