Feature: NegativeFeature

As I login Mars-QA application
I would like to add ,update and delete language details in languages
So that I can manage language details successfully 


Scenario:01- Adding a invalidlanguage to user profile
	Given User has successfully logged into Mars-QA 
	When Add invalid language '<Language>','<Level>' into user profile 
	Then Invalid language should not be added '<Language>','<Level>' 

	Examples: 
	| Language | Level                 |
	| Tamil    |                       |
	| Telugu   | Basic                 |
	|          | Choose Language Level |
	| Hindi    | Choose Language Level |
	
	Scenario Outline:02- Update the invalidlanguage to user profile
	  Given User has successfully logged into Mars-QA 
	  When Update invalid language '<Language>','<Level>' into user profile
	  Then Invalid language should not be updated '<Language>','<Level>'
	  
	  Examples: 
	  | Language | Level                 |
	  |          | Basic                 |
	  | Telugu   | Basic                 |
	  |          |Language Level         |
	  | Hindi    |Language Level         |

	 Scenario Outline:03- Adding a invalidskill to user profile
	   Given User has successfully logged into Mars-QA application
	   When Add invalid skill '<Skill>','<Level>' into user profile
	   Then Invalid skill should not be added '<Skill>','<Level>'

	 Examples: 
	 | Skill | Level              |
	 | C#    | Choose Skill Level |
	 | API   | Beginner           |
	 |       | Choose Skill Level |
	 

	 Scenario Outline:04- Update the invalidskill to user profile
	  Given User has successfully logged into Mars-QA application
	  When Update invalid skill '<Skill>','<Level>' into user profile
 	  Then Invalid skill should not be updated '<Skill>','<Level>'

	 Examples: 
	 | Skill  | Level              |
	 | C#     | Expert             |
	 | Python |  Skill Level       |
	 |        |  Skill Level       |
	

	
