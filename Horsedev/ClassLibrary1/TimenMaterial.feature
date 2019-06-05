Feature: TimenMaterial
	Create,Edit,Delete and Validate Time and Material records

@mytag
Scenario: Create and Validate new record
	Given I am in the Horsedev Portal
	And I have Clicked Administration and Time and Material Tab
	When I Click CreateNew Button and Enter valid data
	Then I should be able to Create new record and Validate 
