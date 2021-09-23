Feature: AP_ShoppingCart
	Shopping Cart page

@ShoppingCart
Scenario: Go To Cart
	Given I am on the user page
	When I click the shopping cart image
	Then the page with title "Your Cart" is loaded

@ShoppingCart
Scenario: Go back to user page
	Given I am on the user page
	And I have navigated to shopping cart
	When I click the continue shopping button
	Then the page with title "products" is loaded

@ShoppingCart
Scenario: Go To Checkout Page
	Given I am on the user page
	And I have navigated to shopping cart
	When I click the checkout button
	Then the page with title "Checkout: Your Information" is loaded