using MarsQA.Pages;
using MarsQA.Utilities;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace MarsQA.StepDefinitions
{
    [Binding]
    public class LanguageFeatureStepDefinitions : CommonDriver
    {
        [Given(@"User has successfully logged into Mars-QA application")]
        public void GivenUserHasSuccessfullyLoggedIntoMars_QAApplication()
        {
            driver = new ChromeDriver();
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginSteps(driver);
        }

        [When(@"Add the language into user profile")]
        public void WhenAddTheLanguageIntoUserProfile()
        {
            LanguagePage languagePageObj = new LanguagePage();
            languagePageObj.AddLanguage(driver);

        }

        [Then(@"Languages should be added successfully")]
        public void ThenLanguagesShouldBeAddedSuccessfully()
        {
            LanguagePage languagePageObj = new LanguagePage();
            string newLanguage = languagePageObj.GetVerifyLanguageAdd(driver);
            Assert.AreEqual("Tamil",newLanguage, "Actual language and expected language do not match");
            

        }
    }
}
