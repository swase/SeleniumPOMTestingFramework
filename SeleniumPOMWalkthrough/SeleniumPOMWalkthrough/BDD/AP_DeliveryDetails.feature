Feature: AP_DeliveryDetails
	Test Checkout page

@Delivery
Scenario: No Delivery Details Given
Given I am on delivery details page
And I have the following delivery information
| FirstName | LastName | PostalCode |
|           |          |          |
When I enter this delivery information
And I click the continue button
Then I should see an alert containing the error message "Error: First Name is required"

@Delivery
Scenario: LastName not entered
Given I am on delivery details page
And I have the following delivery information
| FirstName			| LastName | PostalCode |
|    Mr Loco		|          |          |
When I enter this delivery information
And I click the continue button
Then I should see an alert containing the error message "Error: Last Name is required"

@Delivery
Scenario: FirstName not entered
Given I am on delivery details page
And I have the following delivery information
| FirstName			| LastName			| PostalCode			|
|					|     SomeThing     |   se10 g91		|
When I enter this delivery information
And I click the continue button
Then I should see an alert containing the error message "Error: First Name is required"


@Delivery
Scenario: PostCode not entered
Given I am on delivery details page
And I have the following delivery information
| FirstName			| LastName		| PostalCode			|
|    	Mr			|   Bean		|    				|
When I enter this delivery information
And I click the continue button
Then I should see an alert containing the error message "Error: Postal Code is required"

@Delivery
Scenario: Cancel delivery 
Given I am on delivery details page
When I click the cancel button
Then the page with title "your cart" is loaded

