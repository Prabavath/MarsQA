Feature: LanguageFeature

As I login Mars-QA application
I would like to add ,update and delete language details in languages
So that I can manage language details successfully 

Language added to profile
Scenario:01- Adding a language to user profile
	Given User has successfully logged into Mars-QA application
	When Add language'<Language>','<Level>' into user profile
	Then Languages should be added '<Language>','<Level>' successfully

	Examples:
	| Language | Level          |
	| Tamil    | Fluent         |
	| S@#112   | Basic          |
	| Kanada   | Conversational |
	| Telugu   | Basic          |
	

Scenario Outline:02-Update the existing language details
   Given User has successfully logged into Mars-QA application
   When Update '<Language>','<Level>' on an existing language details
   Then Language should been updated '<Language>','<Level>'

   Examples: 
   | Language | Level          |
   | Korean   | Fluent         |
   | &*NM(94) | Basic          |
   | English  | Conversational |
   | Spanish  | Fluent         |

   Scenario Outline:03- Delete the existing language details
   Given User has successfully logged into Mars-QA application
   When Delete '<Language>','<Level>' on an existing details
   Then Language should be deleted '<Language>','<Level>'

   Examples:
   | Language | Level |
   | Spanish  | Fluent|
   