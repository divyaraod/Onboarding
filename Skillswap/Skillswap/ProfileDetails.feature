Feature: ProfileDetailsFeature
	
	As a Seller
	I want to add,update,delete all my profile details

@mytag
Scenario: Add Description to my Profile
	Given I have log in and in my Profile Page
	And entered description in the text box
	Then I should be able to add description in my profile

@mytag
Scenario: Add or update name in my profile
    Given I have log in and in my Profile Page
	And entered first name and last name and press save button
	Then I should be able to add or update name in my profile

@mytag
Scenario: Add Availability and hours and earn target to my Profile
	Given I have log in and in my Profile Page
	And entered availability,hours and earn target details
	Then I should be able to add the details in my profile

@mytag
Scenario: Add Description to my Profile
	Given I have log in and in my Profile Page
	And entered description in the text box
	Then I should be able to add description in my profile

@mytag
Scenario: Add new Certifications to my Profile
	  Given I have log in and in my Profile page and clicked on Certifications tab
	  And clicked on the add new button and entered the details
	  Then I should be able to add the certification in my profile

@mytag
Scenario: Edit existing Certifications to my Profile
	  Given I have log in and in my Profile page and clicked on Certifications tab
	  And clicked on the write button of the certification to be edited and update the details
	  Then I should be able to update the certification in my profile

@mytag
Scenario: Delete existing Certifications in my Profile
	  Given I have log in and in my Profile page and clicked on Certifications tab
	  And clicked on the remove button of the certification to be deleted
	  Then I should be able to delete the certification in my profile


