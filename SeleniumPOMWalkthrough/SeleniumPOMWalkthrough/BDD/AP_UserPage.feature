Feature: AP_UserPage

@AddItem
Scenario: Add backpack  to basket
	Given I am on the user page
	When I click the add to cart button for the backpack
	Then the shopping cart button should increase by 1

@AddItem
Scenario: Add all items to cart
	Given I am on the user page
	When I click the add to cart button for all items on the page
	Then the shopping cart should show 6 items

@AddItem
Scenario: Remove all items from cart
	Given I am on the user page
	And all the items have been added to the cart
	When I click the remove button for all items on the page
	Then the shopping cart should show 0 items

