Feature: SkillFeature

As I login Mars-QA application
I would like to add skill details in skills
So that I can manage skill details successfully

Skills added to profile
Scenario:01- Adding a skill to user profile
Given User has successfully logged into the Mars-QA application
When Add skill'<Skill>','<Level>' into user profile
Then skills should be added '<Skill>','<Level>' successfully

Examples: 
| Skill | Level        |
| Java  | Beginner     |
| C#    | Intermediate |
| API   | Beginner     |
| SQL   | Expert       |

Scenario Outline:02- Update the existing skill details
Given User has successfully logged into Mars-QA application
When Update skill '<Skill>','<Level>' on an existing skill details into profile
Then Skill should been updated '<Skill>','<Level>'

Examples: 
| Skill | Level        |
| C#    | Expert       |
| v11@a | Beginner     |
|Phython| Expert       |
| SQL   | Beginner     |

Scenario Outline:03- Delete the existing skill details
Given User has successfully logged into Mars-QA application
When Delete '<Skill>','<Level>' on an existing skill details
Then Skill should be deleted '<Skill>','<Level>'

Examples: 
| Skill | Level    |
| SQL   | Beginner |

