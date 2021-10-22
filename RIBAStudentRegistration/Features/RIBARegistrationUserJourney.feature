Feature: RIBAUserJourneyFeature
	As a student
	I want to fill the Registration form 
	So that I can get registered. 

@RIBAUserJourneyRegistrationpage @Regression
Scenario: User Journey of Registration page
	Given I navigate to RIBA Url
	And I click on allow all cookies button
	Then It will show me the Registration Form
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
	Then I will see success page 

	#
#	@FieldsValidation @Sanity
#Scenario Outline: Fields Validation
#	Given I navigate to RIBA Url
#	And I click on allow all cookies button
#	Then It will show me the Registration Form
#	When I enter "<Fields>" in Registration page
#	    And I select Title 
#		And I delete previously added <Fields> from Regisrtation page
#		Then It should show repective error message.
#
#		Examples:
#		| Fields          |
#		| Youremail       |
#		| Secondaryemail  |
#		| DateOfBirth     |
#		| StartDate       |
#		| CompletionDate  |
#		| Password        |
#		| ConfirmPassword |

#		@DateValidation @sanity
#	Scenario Outline:Invalid Date Format 
#	Given I navigate to RIBA Url
#	And I click on allow all cookies button
#	Then It will show me the Registration Form
#	When I enter email in Your Email
#	    And I select Title 
#	    And I enter First name
#	    And I enter Surname
#	    And I select Gender
#	    And I enter "<date>" in invalid format
#		Then It should show me error message.
#	    And I select Ethnic origin
#	    And I enter phone number
#	    And I enter Secondary email
#	    And I select the overseas check box
#	    And I enter Address lineone, Address linetwo, Address linethree.
#	    And I enter Town or City
#	    And I enter County or Region
#		And I enter PostCode
#		And I select Country
#		And I select Partone institution
#		And I select Partone course name
#		And I enter Partone start "<date>"
#		And I enter Partone completion "<date>"
#		Then It will show error message
#		And I select Parttwo institution
#		And I select Parttwo course name
#		And I enter Parttwo start "<date>"
#		And I enter Parttwo completion "<date>"
#		Then It will show error message
#
#		Examples:
#		| date      |
#		| 2222222   |
#		| 22/02/199 |
#		| abcdef    |

	#	@DateCompletionmorethanstartdate @sanity
	#Scenario Outline: To validate completion date is after the start date
	#Given I navigate to RIBA Url
	#And I click on allow all cookies button
	#Then It will show me the Registration Form
	#When I enter email in Your Email
	#    And I select Title 
	#    And I enter First name
	#    And I enter Surname
	#    And I select Gender
	#    And I enter date in valid format DD/MM/YYYY
	#	Then It should show me error message.
	#    And I select Ethnic origin
	#    And I enter phone number
	#    And I enter Secondary email
	#    And I select the overseas check box
	#    And I enter Address lineone, Address linetwo, Address linethree.
	#    And I enter Town or City
	#    And I enter County or Region
	#	And I enter PostCode
	#	And I select Country
	#	And I select Partone institution
	#	And I select Partone course name
	#	And I enter Partone "<startdate1> "22/11/2013
	#	And I enter Partone "<completiondate1>" 23/11/2012
	#	Then It will show error message if completion is before start date
	#	And I select Parttwo institution
	#	And I select Parttwo course name
	#	And I enter Parttwo "<startdate2> "
	#	And I enter Parttwo "<completiondate2>" 
	#	Then It will show error message if completion is before start date
	#Examples:
	#| startdate1 | completiondate1 | startdate2 | completiondate2 |
	#| 22/11/2013 | 23/11/2012      | 22/05/2019 | 22/11/2021      |
	#| 22/12/2013 | 23/10/2010      | 22/05/2021 | 22/11/2019      |


		


	#@Declarationnotchecked	
	#Scenario: Declaration should be ticked before proceeding
	#Given I navigate to RIBA Url
	#And I click on allow all cookies button
	#Then It will show me the Registration Form
	#When I enter email in Your Email
	#    And I select Title 
	#    And I enter First name
	#    And I enter Surname
	#    And I select Gender
	#    And I enter date in DD/MM/YYYY format
	#    And I select Ethnic origin
	#    And I enter phone number
	#    And I enter Secondary email
	#    And I select the overseas check box
	#    And I enter Address lineone, Address linetwo, Address linethree.
	#    And I enter Town or City
	#    And I enter County or Region
	#	And I enter PostCode
	#	And I select Country
	#	And I select Partone institution
	#	And I select Partone course name
	#	And I enter Partone start date
	#	And I enter Partone completion date
	#	And I select Parttwo Institution name
	#	And I select Parttwo course name
	#	And I enter Parttwo start date
	#	And I enter Parttwo completion date
	#	And I enter Password in Password Section
	#	And I enter in password in Retype Password
	#	And I don't select check box of Declaration
	#When I try to click on Register button 
	#Then it will show me error message.
	



	