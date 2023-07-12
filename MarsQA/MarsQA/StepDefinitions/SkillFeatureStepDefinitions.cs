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
        LoginPage loginPageObj;
        SkillPage skillPageObj;

        public SkillFeatureStepDefinitions()
        {
            loginPageObj = new LoginPage();
            skillPageObj = new SkillPage();
        }
        [Given(@"User has successfully logged into the Mars-QA application")]
        public void GivenUserHasSuccessfullyLoggedIntoTheMars_QAApplication()
        { 
            loginPageObj.LoginSteps();

        }
        [When(@"Add skill'([^']*)','([^']*)' into user profile")]
        public void WhenAddSkillIntoUserProfile(string skill, string level)
        {
            skillPageObj.AddSkill(skill,level);
        }
        [Then(@"skills should be added '([^']*)','([^']*)' successfully")]
        public void ThenSkillsShouldBeAddedSuccessfully(string skill, string level)
        {
            string newSkill = skillPageObj.GetVerifySkillAdd();
            string newLevel = skillPageObj.GetVerifySkillLevel();
            Assert.AreEqual(skill, newSkill, "Actual skill and expected skill do not match");
            Assert.AreEqual(level, newLevel, "Actual level and expected level do not match");
        }
        [When(@"Update skill '([^']*)','([^']*)' on an existing skill details into profile")]
        public void WhenUpdateSkillOnAnExistingSkillDetailsIntoProfile(string skill, string level)
        {
            skillPageObj.UpdateSkill(skill,level);
        }

            
        [Then(@"Skill should been updated '([^']*)','([^']*)'")]
        public void ThenSkillShouldBeenUpdated(string skill, string level)
        {
            string updatedSkill = skillPageObj.GetVerifyUpdateSkill();
            string updatedLevel = skillPageObj.GetVerifyUpdateLevel();
            Assert.AreEqual(skill, updatedSkill, "Actual skill and expected skill do not match");
            Assert.AreEqual(level, updatedLevel, "Actual level and expected level do not match");
        }

        [When(@"Delete '([^']*)','([^']*)' on an existing skill details")]
        public void WhenDeleteOnAnExistingSkillDetails(string skill, string level)
        {
           skillPageObj.DeleteSkill(skill,level);
        }
        [Then(@"Skill should be deleted '([^']*)','([^']*)'")]
        public void ThenSkillShouldBeDeleted(string skill, string level)
        {
            string deletedSkill = skillPageObj.GetVerifyDeleteSkill();
            string deletedLevel = skillPageObj.GetVerifyDeleteLevel();
            Assert.AreNotEqual(skill, deletedSkill, "Actual skill and expected skill do not match");
            Assert.AreNotEqual(level, deletedLevel, "Actual level and expected level do not match");
        }

        
    }
}
