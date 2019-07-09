Feature: EducationFeature
	In order to update my profile 
	As a skill trader
	I want to add,edit and delete the education

@myTag
Scenario Outline: Check if user is able to add education
	Given I have log in and in my Profile page and clicked on Education tab
	And I have entered Education data like year country title <university> and <degree> and press add button
	Then I should be able to add new Education entry to my profile
	Examples: 
	| university | degree |
	| JNTU       | IT     |
	| Kakatiya   | CSE    |

@myTag
Scenario: Check if user is able to edit education
    Given I have log in and in my Profile page and clicked on Education tab
	And I have edited Education details and press update button
	Then I should be able to edit Education details to my profile

@myTag
Scenario: Check if user is able to remove education
    Given I have log in and in my Profile page and clicked on Education tab
	And I have pressed remove icon of the education entry which needs to be deleted
	Then I should be able to delete Education entry in my profile
