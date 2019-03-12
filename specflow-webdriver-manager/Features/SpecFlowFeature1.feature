Feature: SpecFlowFeature1
	I want to go to specflow page

@mytag
Scenario: Go to page and click link with success
	Given I go to "https://specflow.org/" page
	When I click "Contribute on Github" link
	Then should be on "https://github.com/techtalk/SpecFlow" page

Scenario: Go to page failed
	Given I go to "https://specflow.org/" page
	Then should be on "https://specflow.org/tretete" page
