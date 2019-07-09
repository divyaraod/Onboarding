Feature: ProfileDetails
	In order to update my profile 
	As a skill trader
	I want to add,update,delete all my profile details accordingly

@mytag
Scenario: Check if user could able to update name
    Given I have log in and in my Profile Page
	And entered first name and last name and press save button
	Then I should be able to update name in my profile

@mytag
Scenario: Check if user could able to add availability hours and earn target
	Given I have log in and in my Profile Page
	And entered availability,hours and earn target details
	Then I should be able to add the details in my profile

@mytag
Scenario: Check if user could able to add a description
	Given I have log in and in my Profile Page
	And entered description in the text box
	Then I should be able to add description in my profile

	@mytag
Scenario: Check if user could able to add a certification
	  Given I have log in and in my Profile page and clicked on Certifications tab
	  And clicked on the add new button and entered the details
	  Then I should be able to add the certification in my profile

@mytag
Scenario: Check if user is able to edit a cerification 
	  Given I have log in and in my Profile page and clicked on Certifications tab
	  And clicked on the write button of the certification to be edited and update the details
	  Then I should be able to update the certification in my profile

@mytag
Scenario: Check if user is able to remove a certification 
	  Given I have log in and in my Profile page and clicked on Certifications tab
	  And clicked on the remove button of the certification to be deleted
	  Then I should be able to delete the certification in my profile
