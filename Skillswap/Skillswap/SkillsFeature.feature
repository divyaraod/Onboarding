Feature: SkillsFeature
	 As a Seller
	I want to add,update and delete Skills to my profile

@mytag
Scenario Outline: Add new Skills to Seller Profile
	Given I have log in and in my Profile page and clicked on skills tab
	And I have entered <Skill> which is not duplicate and level and press add button
	Then I should be able to add skill to my profile
	Examples: 
	| Skill   |
	| Cooking |
	| Dancing |
	
@mytag
Scenario: Edit the existing Skills in Seller Profile
      Given I have log in and in my Profile page and clicked on skills tab
	  And clicked on the write button of the skill to be edited and update the details
	  Then I should be able to update the skill in my profile

@mytag
Scenario: Delete the existing Skill in Seller Profile
    Given I have log in and in my Profile page and clicked on skills tab
	And clicked on the remove button of the Skill to be deleted
	Then I should be able to delete the skill from my profile