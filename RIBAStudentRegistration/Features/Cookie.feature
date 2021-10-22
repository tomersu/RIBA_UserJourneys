Feature: Cookiefeature
	As a Student
	I want to click on Cookie 
	So that I can visit Registration Page

@CookieManageCheck @Regression @Smoke 
Scenario: To check the Manage my preferences Cookie functionality
	Given I navigate to RIBA Url for cookie test
	When I click on Manage my preferenes button
	And I click on prefernces option
	And I click on Allow my selection
	Then I will see reistration page