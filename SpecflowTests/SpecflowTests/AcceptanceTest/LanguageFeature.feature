Feature: LanguageFeature
	In order to update my profile 
	As a skill trader
	I want to add,edit and delete the languages that I know

@mytag
Scenario: Check if user could able to add a language 
	Given I clicked on the Language tab under Profile page
	When I add a new language
	Then that language should be displayed on my listings
	
@mytag
Scenario: Check if user is able to edit a language 
	Given I clicked on the Language tab under Profile page
	When I update existing language
	Then that language should be updated on my listings

@mytag
Scenario: Check if user is able to remove a language 
	Given I clicked on the Language tab under Profile page
	When I delete existing language
	Then that language should be deleted from my listings