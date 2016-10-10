@featuretag
Feature: FeatureOne
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

Scenario Outline: Some scenario outline
	Given I have entered 50.5 into the calculator
	And I have entered 70.3 into the calculator
	When I press add
	Then the result should be "<total>" on the screen

	@en-gb
	Examples:
	| total |
	| 120.8 |

	@fr-fr
	Examples:
	| total |
	| 120,8 |