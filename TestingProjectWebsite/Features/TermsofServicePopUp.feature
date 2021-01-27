Feature: TermsOfServicePopup
	When  order a product
	You must agree to Terms of Service
	And a popup must be shown in the page

@mytag
Scenario: TermsOfServicePopup
	Given I am logged in with following user
			| userEmail        | userPassword        |
			| <userEmailValue> | <userPasswordValue> |
	And I add a product into cart
	When I complete the checkout process
	Then I am shown a popup if terms of service is not checked

Examples: 
| userEmailValue         | userPasswordValue |
| test123xyz@test.com    | password          |