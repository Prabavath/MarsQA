using MarsQA.Pages;
using MarsQA.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Reflection.Emit;
using TechTalk.SpecFlow;

namespace MarsQA.StepDefinitions
{
    [Binding]
    public class NegativeFeatureStepDefinitions : CommonDriver 
    {
        LoginPage loginPageObj;
        NegativePage negativePageObj;
        NegativeSkillPage negativeSkillPageObj;
        public NegativeFeatureStepDefinitions() 
        {
            loginPageObj = new LoginPage();
            negativePageObj=new NegativePage();
            negativeSkillPageObj = new NegativeSkillPage();
        }
        [Given(@"User has successfully logged into Mars-QA")]
        public void GivenUserHasSuccessfullyLoggedIntoMars_QA()
        {
            loginPageObj.LoginSteps();
        }

        [When(@"Add invalid language '([^']*)','([^']*)' into user profile")]
        public void WhenAddInvalidLanguageIntoUserProfile(string language, string level)
        {
            negativePageObj.AddLanguage(language, level);
        }
        [Then(@"Invalid language should not be added '([^']*)','([^']*)'")]
        public void ThenInvalidLanguageShouldNotBeAdded(string language, string level)
        {
            //Assertion of added language
            string newLanguage = negativePageObj.GetVerifyLanguageAdd();
            string newLevel = negativePageObj.GetVerifyLevelAdd();
            if (language == newLanguage && level == newLevel)
            {
                Assert.AreEqual(language, newLanguage, "Actual language and expected language do not match");
                Assert.AreEqual(level, newLevel, "Actual level and expected level do not match");
            }
            else 
            {
                Console.WriteLine("Check error");
            }

        }

        [When(@"Update invalid language '([^']*)','([^']*)' into user profile")]
        public void WhenUpdateInvalidLanguageIntoUserProfile(string language, string level)
        {
            negativePageObj.UpdateLanguage(language, level);
        }
        [Then(@"Invalid language should not be updated '([^']*)','([^']*)'")]
        public void ThenInvalidLanguageShouldNotBeUpdated(string language, string level)
        {
            //Assertion of updated language
            string updatedLanguage = negativePageObj.GetVerifyUpdateLanguage();
            string updatedLevel = negativePageObj.GetVerifyUpdateLevel();
            if (language == updatedLanguage && level == updatedLevel)
            {
                Assert.AreEqual(language, updatedLanguage, "Actual language and expected language do not match");
                Assert.AreEqual(level, updatedLevel, "Actual level and expected level do not match");
            }
            else
            {
                Console.WriteLine("Check error");
            }
        }
        [When(@"Add invalid skill '([^']*)','([^']*)' into user profile")]
        public void WhenAddInvalidSkillIntoUserProfile(string skill, string level)
        {
            negativeSkillPageObj.AddSkill(skill, level);
        }
        [Then(@"Invalid skill should not be added '([^']*)','([^']*)'")]
        public void ThenInvalidSkillShouldNotBeAdded(string skill, string level)
        {
            string newSkill = negativeSkillPageObj.GetVerifySkillAdd();
            string newSkillLevel = negativeSkillPageObj.GetVerifySkillLevel();
            if (skill == newSkill && level == newSkillLevel)
            {
                Assert.AreEqual(skill, newSkill, "Actual skill and expected skill do not match");
                Assert.AreEqual(level, newSkillLevel, "Actual level and expected level do not match");
            }
            else
            {
                Console.WriteLine("Check error");
            }

        }
        [When(@"Update invalid skill '([^']*)','([^']*)' into user profile")]
        public void WhenUpdateInvalidSkillIntoUserProfile(string skill, string level)
        {
            negativeSkillPageObj.UpdateSkill(skill, level);
        }
        [Then(@"Invalid skill should not be updated '([^']*)','([^']*)'")]
        public void ThenInvalidSkillShouldNotBeUpdated(string skill, string level)
        {
            string updatedSkill = negativeSkillPageObj.GetVerifyUpdateSkill();
            string updatedLevel = negativeSkillPageObj.GetVerifyUpdateLevel();
            if (skill == updatedSkill && level == updatedLevel)
            {
                Assert.AreEqual(skill, updatedSkill, "Actual skill and expected skill do not match");
                Assert.AreEqual(level, updatedLevel, "Actual level and expected level do not match");
            }
            else
            {
                Console.WriteLine("Check error");
            }
        }
    }
}
