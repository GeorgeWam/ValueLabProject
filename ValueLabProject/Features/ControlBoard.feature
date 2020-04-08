Feature: ControlBoard
	As an online Shopper, a user should be able to sign into their account, Get savings deal, access the "contact us" screen, 
	 search of a new Item, and view their cart. 


Scenario: Controlboard_01_Verify that a user is able to sign into their account
	Given that the online shopping url is launched
	And a user clicks the sign in button
	And a user fill in their email address with georgeiwoiltd@aol.com
	And a user fill in their password with ValueLab1
	When the user clicks the sign in button
	Then the users name Papi Papi should be displayed on their home screen


	Scenario: Controlboard_02_Verify that a user ia able to access the saving deal link
	Given that the online shopping url is launched
	And a user clicks the sign in button
	And a user fill in their email address with georgeiwoiltd@aol.com
	And a user fill in their password with ValueLab1
	When the user clicks the sign in button
	And the user clicks the GET SAVINGS NOW Link
	Then the GET SAVINGS NOW Url http://automationpractice.com/index.php?controller=my-account should be displayed

	Scenario: Controlboard_03_Verify that a user is able to access the Contact Us screen
	Given that the online shopping url is launched
	And a user clicks the sign in button
	And a user fill in their email address with georgeiwoiltd@aol.com
	And a user fill in their password with ValueLab1
	When the user clicks the sign in button
	And the user clicks the Contact us button
	Then the CUSTOMER SERVICE - CONTACT US screen is displayed

	Scenario: Controlboard_04_Verify that a user is able to search an item using the search field
	Given that the online shopping url is launched
	And a user clicks the sign in button
	And a user fill in their email address with georgeiwoiltd@aol.com
	And a user fill in their password with ValueLab1
	When the user clicks the sign in button
	And the user fills in Blouse in the search field
	And the user clicks the search icon
	Then the screen should display TOP SELLERS with the searched item