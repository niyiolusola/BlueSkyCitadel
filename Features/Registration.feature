Feature: Registration
	As an intending user of longrichway.com
	I want to register a new account
	So I can buy products


@mytag
Scenario: Valid Registration
	Given a user navigates to "https://longrichway.com/"
	When the user Clicks on register
	And the user enters First Name "Adetoro"
	And the user enters Last Name "Tade"
	And the user enters Email Address "tadeto1@gmail.com"
	And the user enters Phone "07403554930"
	And the user enters Password "P@ssw0rd"
	And the user enters Confirm Password "P@ssw0rd"
	And the user enters Address "3 Miles Lodge"
	And the user enters TownCity "London"
	And the user enters State "England"
	And the user Clicks on Create Account
	Then the user is logged into New Account