﻿Feature: LoanCalculator
	As a user 
	I want to chach the bank calculation
	So that I know wich offer to pick

Scenario: Calculate personal loan
	Given that the personal loan calculator is open
	When the amount is set
	And the rait is set 
	And the loan term is set
	And I click the calculate button
	Then the monthy pay is calculated
	And number sof months is correct
