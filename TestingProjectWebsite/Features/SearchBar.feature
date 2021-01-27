Feature: SearchBar
	In order to find a product using search bar
	As a user
	I want find the product

@mytag
Scenario: SearchBar
	Given I write 'dress' in the search bar
	And I click seach button
	Then I am shwn only dresses