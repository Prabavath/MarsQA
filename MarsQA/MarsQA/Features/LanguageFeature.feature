Feature: LanguageFeature

As I login Mars-QA application
I would like to add language details in languages
So that I can manage language details successfully 

Language added to profile
Scenario: Adding a language to user profile
	Given User has successfully logged into Mars-QA application
	When Add the language into user profile
	Then Languages should be added successfully
