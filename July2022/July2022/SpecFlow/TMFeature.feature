Feature: TMFeature

As a TurnUp portal admin 
I would like to create, edit and delete the time and material records
So that I can manage employees time and material successfully


Scenario: 1 Create material record with valid data
	Given I logged into TurnUp portal successfully
	When when I navigate to time and material page
	When I create a new record 
	Then the record should be created Successfully

Scenario Outline: 2 edit existing material with valid details
   Given I logged into TurnUp portal successfully
   When when I navigate to time and material page
   When I update '<Code>', '<Description>', '<Price>' of an existing material record
   Then the '<Code>', '<Description>', '<Price>' should be edited/Updated

   Examples: 
   | Code     | Description | Price  |
   | Product1 | Green      | $30.00 |
   | Product2 | Purple     | $20.00 |
   | PRoduct3 | Yellow     | $35.00 |

