Feature: Purchase and Create Account
	Purchase and create account

Background: common login steps
	Given mark navigates to site "xxx"

@sanity
Scenario: Order T-Shirt and Create Account
	Given mark wants to order a T-Shirt 
	When mark selects and add to basket
	Then mark create an account with email "xxx"
	And mark completes the purchase