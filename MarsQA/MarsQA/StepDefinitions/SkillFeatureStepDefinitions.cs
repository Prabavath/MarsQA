using MarsQA.Pages;
using MarsQA.Utilities;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools;
using System;
using System.Reflection.Emit;
using TechTalk.SpecFlow;

namespace MarsQA.StepDefinitions
{
    [Binding]
    public class SkillFeatureStepDefinitions : CommonDriver
    {
        [Given(@"User has successfully logged into the Mars-QA application")]
        public void GivenUserHasSuccessfullyLoggedIntoTheMars_QAApplication()
        {
            driver = new ChromeDriver();
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginSteps(driver);

        }

        [When(@"Add the skill into user profile")]
        public void WhenAddTheSkillIntoUserProfile()
        {
            SkillPage skillPageObj = new SkillPage();
            skillPageObj.AddSkill(driver);
        }

        [Then(@"skills should be added successfully")]
        public void ThenSkillsShouldBeAddedSuccessfully()
        {
            SkillPage skillPageObj = new SkillPage();
            string newSkill = skillPageObj.GetVerifySkillAdd(driver);
            string newLevel = skillPageObj.GetVerifySkillLevel(driver);
            Assert.AreEqual("Java", newSkill, "Actual skill and expected skill do not match");
            Assert.AreEqual("Beginner", newLevel, "Actual level and expected level do not match");
        }

        [When(@"Update '([^']*)','([^']*)' on an existing skill details")]
        public void WhenUpdateOnAnExistingSkillDetails(string skill, string level)
        {
            SkillPage skillPageObj = new SkillPage();
            skillPageObj.UpdateSkill(driver,skill,level);
        }
        [Then(@"Skill should been updated '([^']*)','([^']*)'")]
        public void ThenSkillShouldBeenUpdated(string skill, string level)
        {
            SkillPage skillPageObj = new SkillPage();
            string updatedSkill = skillPageObj.GetVerifyUpdateSkill(driver);
            string updatedLevel = skillPageObj.GetVerifyUpdateLevel(driver);
            Assert.AreEqual(skill, updatedSkill, "Actual skill and expected skill do not match");
            Assert.AreEqual(level, updatedLevel, "Actual level and expected level do not match");
        }

        [When(@"Delete '([^']*)','([^']*)' on an existing skill details")]
        public void WhenDeleteOnAnExistingSkillDetails(string skill, string level)
        {
            SkillPage skillPageObj = new SkillPage();
            skillPageObj.DeleteSkill(driver,skill,level);
        }
        [Then(@"Skill should be deleted '([^']*)','([^']*)'")]
        public void ThenSkillShouldBeDeleted(string skill, string level)
        {
            SkillPage skillPageObj = new SkillPage();
            string deletedSkill = skillPageObj.GetVerifyDeleteSkill(driver);
            Assert.AreEqual(skill, deletedSkill, "Actual skill and expected skill do not match");
        }
    }
}
