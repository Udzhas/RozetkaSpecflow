Feature: AddingToCartWithSearch
	


Scenario: Add item to cart after search and filter
	Given I am on Rozetka page
	And I search for 'Apple Iphone 12'
	Then I click Search button
	Then I filter for mobile phones only
	When I click on item
	Then I add to cart this item
