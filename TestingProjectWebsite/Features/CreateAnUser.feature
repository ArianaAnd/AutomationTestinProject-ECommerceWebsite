Feature: CreateAnUser
	In order access an accout
	I have to create an user

@mytag
Scenario: CreateAnUser
	Given I navigate to website and click login
	Then I fill desired email
	| userEmail        |
	| <userEmailValue> |
	When I fill the register form with following data
			| userFirstName        | userLastName        | userPhone        | userAddress        | userPassword        | userAddressFirstName        | userAddressLastName        | userCity        | userPostalCode        |
			| <userFirstNameValue> | <userLastNameValue> | <userPhoneValue> | <userAddressValue> | <userPasswordValue> | <userAddressFirstNameValue> | <userAddressLastNameValue> | <userCityValue> | <userPostalCodeValue> |
	And I click the register button
	Then I am successfully logged in

Examples: 
| userEmailValue          | userFirstNameValue | userLastNameValue | userPhoneValue | userAddressValue  | userPasswordValue | userAddressFirstNameValue | userAddressLastNameValue | userCityValue | userPostalCodeValue |
|  test100@test.com    | Andrisan           | Ariana            | 111-222-333    |Strada, 2          | password          | Andrisan                  | Ariana                   | Brasov        | 000000              |