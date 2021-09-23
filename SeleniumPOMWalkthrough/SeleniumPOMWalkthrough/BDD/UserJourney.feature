Feature: UserJourney
	Example User Journey's

Scenario: User buys a backpack
Given I have the following credentials
| Email				| Password		|
| standard_user		| secret_sauce	|
And I have the following delivery information
| FirstName	| LastName	| PostalCode	|
| Mr		|   Bean	| OX20 BDD	|
And I am on the signin page
When I enter these credentials
And I click the sign in button
And I click the add to cart button for the backpack
And I click the shopping cart image
And I click the checkout button
And I enter this delivery information
And I click the continue button
And I click the finish button
Then the page with title "checkout: complete!" is loaded

