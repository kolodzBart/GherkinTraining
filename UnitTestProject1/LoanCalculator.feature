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
Examples: 
	| example description   | amount | rait | term | pay   |
	| Valid data            | 5000   | 5    | 5    | 94.36 |
	| Amount lower boundary | 1	     | 5    | 5    | 0.02  |
	| Rait lower boundary   | 1	     | 0.01 | 5    | 0.02  |

Scenario Outline: Calculate personal loan errors
	Given that the personal loan calculator is open
	When the amount is set <amount>
	And the rait is set <rait>
	And the loan term is set <term>
	And I click the calculate button
	Then An error message is displayed <message>
Examples: 
	| example description   | amount | rait | term | message                                          |
	| Invalid years         | 5000   | 3.4  | -5   | Please provide a positive loan term year value.  |
	| Invalid rate          | 5000   | -1   | 5    | Please provide a positive interest rate value.   |
	| Invalid amount        | -1     | 3.4  | 5    | Please provide a positive loan amount.           |

Scenario: Calculate auto loan
	Given that the auto loan calculator is open
	When the amount is set
	And the rait is set 
	And the auto loan term is set
	And I click the calculate button
	Then the monthy pay is calculated