Feature: BuyAProduct
	In order buy a T-shirt
	I must signIn first
	Add the product to cart and complete checkout

@mytag
Scenario: BuyAProduct
	Given I am logged in with existing user
			| userEmail        | userPassword        |
			| <userEmailValue> | <userPasswordValue> |
	When I add the T-shirt to cart
	And I access the cart to proceed to checkout
	And I finish the checkout steps
	Then My order is completed

Examples: 
| userEmailValue      | userPasswordValue |
| test123xyz@test.com | password          |