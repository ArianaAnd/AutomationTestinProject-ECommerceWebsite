Feature: CheckWishList
Check the wishList functionality
	Will check if one item is saved in wishlist

@mytag
Scenario: CheckWishList
	Given I am logged in with following user
			| userEmail        | userPassword        |
			| <userEmailValue> | <userPasswordValue> |
	When I add a dress to the wish list
	And navigate to account
	Then I see the dress added to the wishlist

Examples: 
| userEmailValue         | userPasswordValue |
| test123xyz@test.com    | password        |