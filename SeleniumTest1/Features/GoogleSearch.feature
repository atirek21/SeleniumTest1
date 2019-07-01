@GoogleHomePage
Feature: Google Search Steps
  
@Positive
Scenario: Google search for positive scenario
	Given I am on Google search page
	When I search 'Aviva' in search field
	Then I should see '191' links returned in the first search page
	And Fetch the fifth link text

@Negative
Scenario: Google search for negative scenario
	Given I am on Google search page
	When I search '''' in search field
	Then I should see '0' links returned in the first search page
