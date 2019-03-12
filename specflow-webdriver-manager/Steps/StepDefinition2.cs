using specflow_webdriver_manager.Assertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace specflow_webdriver_manager.Steps
{
    [Binding]
    public sealed class StepDefinition2
    {

        private StepDefinition1Assertions _stepDefinition1Assertions;

        public StepDefinition2(StepDefinition1Assertions stepDefinition1Assertions)
        {
            _stepDefinition1Assertions = stepDefinition1Assertions;
        }

        [Then(@"should be on ""(.*)"" page")]
        public void ThenShouldBeOnPage(string urlName)
        {
            _stepDefinition1Assertions.AssertPageUrlName(urlName);
        }

    }
}
