Feature: LoanCalculator
	As a user 
	I want to check the bank calculation
	So that I know wich offer to pick

Scenario Outline: Calculate personal loan
	Given that the personal loan calculator is open
	When the amount is set <amount>
	And the rait is set <rait>
	And the loan term is set <term>
	And I click the calculate button
	Then the monthy pay is calculated <pay>
	And number sof months is correct


Scenario: Calculate auto loan
	Given that the auto loan calculator is open
	When the amount is set
	And the rait is set 
	And the auto loan term is set
	And I click the calculate button
	Then the monthy pay is calculated