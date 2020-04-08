Feature: Women
	As an online Shopper, a user should be able to sign into their account and add an item to the cart from the women section.

@mytag
Scenario: Women_01_Verify that a user can add an item from the women department into the cart and display the shopping cart screen
	Given that the online shopping url is launched
	And a user clicks the sign in button
	And a user fill in their email address with georgeiwoiltd@aol.com
	And a user fill in their password with ValueLab1
	When the user clicks the sign in button
	And a user clicks the Women link 
	And a user clicks Dresses link
	And a user clicks Casual Dresses
	And a user scrols down
	And a user clicks a casual dress
	And a user clicks add to cart
	And a user clicks proceed to checkout 
	Then the SHOPPING-CART SUMMARY screen should display Your shopping cart contains: 1 Product item message 
