Feature: Education
	As a Seller
	I should be able to add,update and delete Education entries in my profile

@myTag
Scenario Outline: Add new Education entry to Seller Profile
	Given I have log in and in my Profile page and clicked on Education tab
	And I have entered Education data like year country title <university> and <degree> and press add button
	Then I should be able to add new Education entry to my profile
	Examples: 
	| university | degree |
	| JNTU       | IT     |
	| Kakatiya   | CSE    |

@myTag
Scenario: Edit the existing Education in Seller Profile
    Given I have log in and in my Profile page and clicked on Education tab
	And I have edited Education details and press update button
	Then I should be able to edit Education details to my profile

@myTag
Scenario:Delete the existing Education in Seller Profile
    Given I have log in and in my Profile page and clicked on Education tab
	And I have pressed remove icon of the education entry which needs to be deleted
	Then I should be able to delete Education entry in my profile