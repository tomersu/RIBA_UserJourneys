Feature: Registration PasswordCheck

@UnmatchPassword
Scenario: To validate unmatched password in Registratation page
	Given I navigate to RIBA Url for registrartion
	And I click on allow all cookies button
	Then It will show me the Registration Form page
	When I enter email in Your Email
	    And I select Title 
	    And I enter First name
	    And I enter Surname
	    And I select Gender
	    And I enter date in DD/MM/YYYY format
	    And I select Ethnic origin
	    And I enter phone number
	    And I enter Secondary email
	    And I select the overseas check box
	    And I enter Address lineone, Address linetwo, Address linethree.
	    And I enter Town or City
	    And I enter County or Region
		And I enter PostCode
		And I select Country
		And I select Partone institution
		And I select Partone course name
		And I enter Partone start date
		And I enter Partone completion date
		And I select Parttwo Institution name
		And I select Parttwo course name
		And I enter Parttwo start date
		And I enter Parttwo completion date
		And I enter Password in Password Section
		And I enter in password in Retype Password
		And I select check box of Declaration
	When I click on Register button 
	Then I will see passwordunmatched error