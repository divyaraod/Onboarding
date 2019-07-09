Feature: SkillsFeature
	In order to update my profile 
	As a skill trader
	I want to add,edit and delete the skills that I know

@mytag
Scenario Outline: Check if user could able to add a skill 
	Given I have log in and in my Profile page and clicked on skills tab
	And I have entered <skill> which is not duplicate and level and press add button
	Then I should be able to add skill to my profile
	Examples: 
	| skill   |
	| Cooking |
	| Dancing |
	
@mytag
Scenario: Check if user is able to edit a skill
      Given I have log in and in my Profile page and clicked on skills tab
	  And clicked on the write button of the skill to be edited and update the details
	  Then I should be able to update the skill in my profile

@mytag
Scenario: Check if user could is able to remove a skill
    Given I have log in and in my Profile page and clicked on skills tab
	And clicked on the remove button of the Skill to be deleted
	Then I should be able to delete the skill from my profile
