Feature: LoginFeature
	In order to access the website
	As a valid user
	I want to login to the website

@mytag
Scenario: Successful login with valid Credentials
	Given I am in the Home Page
	And I have navigated to Login Page
	When I enter valid data
	And click on the Login button
	Then I should be able to login successfully
	
	
@mytag
Scenario: Unsuccessful login with invalid Credentials
    Given I am in the Home Page
	And I have navigated to Login Page
	When I enter invalid data
	And click on the Login button
	Then I should not be able to login
