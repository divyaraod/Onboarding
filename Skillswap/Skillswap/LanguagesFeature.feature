Feature: LanguagesFeature
	
	As a Seller
	I want to add,update,delete my languages in my profile page

@mytag
Scenario: Add new languages to Seller Profile
	Given I have log in and in my Profile page and clicked on languages tab
	And I have entered language which is not duplicate and level and press add button
	Then I should be able to add language to my profile
	
@mytag
Scenario: Edit the existing languages in Seller Profile
      Given I have log in and in my Profile page and clicked on languages tab
	  And clicked on the write button of the language to be edited and update the details
	  Then I should be able to update the language in my profile

@mytag
Scenario: Delete the existing languages in Seller Profile
    Given I have log in and in my Profile page and clicked on languages tab
	And clicked on the remove button of the language to be deleted
	Then I should be able to delete the language from my profile

	  
	   
