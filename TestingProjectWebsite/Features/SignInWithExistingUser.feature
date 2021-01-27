Feature: SignInWithExistingUser
	In order make a purchase
	I need to signIn

@mytag
Scenario: SignInWithExistingUser
	Given I click the signIn button
	When I login with the following credentials
		| userEmail        | userPassword        |
		| <userEmailValue> | <userPasswordValue> |
	Then I am successfully logged in

Examples: 
| userEmailValue         | userPasswordValue |
|  test123xyz@test.com   | password          |