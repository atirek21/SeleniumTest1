@GoogleHomePage
Feature: Google Search
  
@Positive
Scenario: Google search for Aviva in Search bar
	Given I am on Google search page
	When I search 'Aviva' in search field
	Then I should see '181' links returned in the first search page
	And Fetch the fifth link text

@Negative
Scenario: Google search for '' in Search bar
	Given I am on Google search page
	When I search '' in search field
	Then I should see '51' links returned in the first search page
	
