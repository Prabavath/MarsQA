using MarsQA.Pages;
using MarsQA.Utilities;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools;
using System;
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
            Assert.AreEqual("Java", newSkill, "Actual skill and expected skill do not match");
        }
    }
}
