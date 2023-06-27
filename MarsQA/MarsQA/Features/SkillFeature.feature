Feature: SkillFeature

As I login Mars-QA application
I would like to add skill details in skills
So that I can manage skill details successfully

Skills added to profile
Scenario: Adding a skill to user profile
Given User has successfully logged into the Mars-QA application
When Add the skill into user profile
Then skills should be added successfully

