Feature: SkillFeature

As I login Mars-QA application
I would like to add skill details in skills
So that I can manage skill details successfully

Skills added to profile
Scenario:01- Adding a skill to user profile
Given User has successfully logged into the Mars-QA application
When Add the skill into user profile
Then skills should be added successfully

Scenario Outline:02- Update the existing skill details
Given User has successfully logged into Mars-QA application
When Update '<Skill>','<Level>' on an existing skill details
Then Skill should been updated '<Skill>','<Level>'

Examples: 
| Skill | Level        |
| C#    | Intermediate |
| v11@a | Beginner     |
| API   | Expert       |
| API   | Beginner     |

Scenario Outline:03- Delete the existing skill details
Given User has successfully logged into Mars-QA application
When Delete '<Skill>','<Level>' on an existing skill details
Then Skill should be deleted '<Skill>','<Level>'

Examples: 
| Skill | Level    |
| API  | Beginner  |

