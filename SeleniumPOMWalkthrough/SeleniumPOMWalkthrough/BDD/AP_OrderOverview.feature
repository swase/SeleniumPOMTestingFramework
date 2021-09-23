Feature: AP_OrderOverview
	Order Confirmation page

@OrderConfirm
Scenario: Confirm Delivery
Given I am on the order confirmation page
When I click the finish button
Then the page with title "checkout: complete!" is loaded

@OrderConfirm
Scenario: Click Cancel
Given I am on the order confirmation page
When I click the cancel button
Then the page with title "products" is loaded

@OrderComplete
Scenario: Go back to Procucts After Completing Order
Given I am on the order confirmation page
And I have chosen to confirm / complete my order
When I click the go back to products button
Then the page with title "products" is loaded

@OrderComplete
Scenario: Shopping Cart should be empty after order completion
Given I am on the order confirmation page
And I have chosen to confirm / complete my order
When I click the go back to products button
Then the shopping cart should show 0 items