using specflow_webdriver_manager.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace specflow_webdriver_manager.Steps
{
    [Binding]
    public sealed class StepDefinition1
    {
        private StepDefinition1PageObjects _stepDefinition1PageObjects;

        public StepDefinition1(StepDefinition1PageObjects stepDefinition1PageObjects)
        {
            _stepDefinition1PageObjects = stepDefinition1PageObjects;
        }

        [Given(@"I go to ""(.*)"" page")]
        public void GivenIGoToPage(string urlToGo)
        {
            _stepDefinition1PageObjects.GetUrl(urlToGo);
        }

        [When(@"I click ""(.*)"" link")]
        public void WhenIClickLink(string linkName)
        {
            _stepDefinition1PageObjects.ClickLink();
        }

    }
}
