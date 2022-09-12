@employee
Feature: Employee
In order to add employee records 
As an admin
I want to modify the employee details in dashboard

#add employee and verify
@low @smoke
Scenario Outline: Add Valid Employee
	Given I have browser with orangehrm page
	When I enter username as '<username>'
	And I enter password as '<password>'
	And I click on login
	And I click on PIM
	And I click on Add Employee
	And I fill the add employee section
		| firstname   | middlename   | lastname | employee_id | toggle_login_detail | username       | password           | confirm_password   | status   |
		| <firstname> | <middlename> | <lname>  | <empid>     | <toggle_login>      | <account_user> | <account_password> | <confirm_password> | <status> |
	And I click on save employee
	Then I should be navigated to personal details section with added employee records
Examples:
	| username | password | firstname | middlename | lname   | empid | toggle_login | account_user   | account_password | confirm_password | status   |
	| Admin    | admin123 | Soudip    | X          | Das     | 1001  | on           | soudip123      | Soudip@123       | Soudip@123       | enabled  |

