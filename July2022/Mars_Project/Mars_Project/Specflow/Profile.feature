Feature: Profile

As a Seller
I want the feature to add my Profile Details
So that
The people seeking for some skills can look into my details.

@Login
Scenario: Test_1. Confirmation of Successful login with valid credentials
	Given Login with valid email address and password 
	Then Should be able to successfully login to the website


@AddLanguage
Scenario Outline: Test_2. Add Language in profile details of the seller
	Given I succesfully logged in to website 
	When I navigate to language tab in the profile
	And I create language details with '<Language>'
	Then the new record for language should be created with '<Language>' successfully
	Examples: 
	| Language | 
	| Hindi    | 

@EditLanguage 
Scenario Outline: Test_3. Edit Laguage in profile details of the seller
	Given I succesfully logged in to website 
	When I navigate to language tab in the profile
	And I Edit '<Language>' details
	Then the existing record for '<Language>' should be updated successfully 
	Examples: 
	| Language | 
	| English  | 
	| Telugu  | 


@DeleteLanguage
Scenario: Test_4. Delete Language in profile details of the seller
	Given I succesfully logged in to website 
	When I navigate to language tab in the profile
	And I delete language details
	Then the record for language should be deleted succesfully


@AddSkill
Scenario Outline: Test_5. Add Skill in profile details of the seller
	Given I succesfully logged in to website 
	When I navigate to Skill tab in the profile
	And I create skill details with '<skill>'
	Then the new record for skill should be created with '<skill>' succesfully
	Examples: 
	| skill | 
	| tech | 
	| Teaching | 

	@EditSkill
Scenario Outline: Test_6. Edit Skill in profile details of the seller
	Given I succesfully logged in to website 
	When I navigate to Skill tab in the profile
	And I Edit skill details with '<skill>'
	Then the existing record for '<skill>'  should be updated succesfully in skill
	Examples: 
	| skill | 
	| Digital Art | 
	| Animation | 

	@DeleteSkill
Scenario Outline: Test_7. Delete Skill in profile details of the seller
	Given I succesfully logged in to website 
	When I navigate to Skill tab in the profile
	And I Delete skill details
	Then the  last record in skill should be deleted succesfully

@Education
Scenario: Test_8. Add Education detaails in profile of the seller
	Given I succesfully logged in to website 
	When I navigate to Education tab in the profile
	And I create education details
	Then the new record for education should be created succesfully

@EditEducation 
Scenario Outline: Test_9. Edit Education in profile details of the seller
	Given I succesfully logged in to website 
	When I navigate to Education tab in the profile
	And I Edit '<College>','<Degree>' education details
	Then the existing record for education '<College>','<Degree>' should be updated succesfully 
	Examples: 
	| College | Degree |
	| JNTU     | Masters |

@DeleteEducation 
Scenario: Test_10. Delete Education in profile details of the seller
	Given I succesfully logged in to website 
	When I navigate to Education tab in the profile
	And I delete education details
	Then the record for education should be deleted succesfully

@ChangePassword 
	Scenario Outline: Test_11. Change Password in profile details of the seller
	Given I succesfully logged in to website 
	When I navigate to change password in the profile
	And Update from '<oldPassword>', '<newPassword>'
	Then Password should be updated successfully 
	Examples: 
	| oldPassword | newPassword |
	| Apples123   | Apples1234  |

