@login
Feature: Login
  In order to login to maintain employee records
  As an user
  I want to login into the portal 
Background:
	Given I have browser with orangehrm page

	@high @valid @smoke
Scenario: Valid Credential
	When I enter username as 'Admin'
	And I enter password as 'admin123'
	And I click on login
	Then I should be navigate to 'PIM' dashboard screen

	@low @invalid
Scenario Outline: Invalid Credential
	When I enter username as '<username>'
	And I enter password as '<password>'
	And I click on login
	Then I should get error message as '<error_message>'
Examples:
	| username  | password  | error_message       |
	| lolpku    | lolpku123 | Invalid credentials |
	| binod     | binod123  | Invalid credentials |