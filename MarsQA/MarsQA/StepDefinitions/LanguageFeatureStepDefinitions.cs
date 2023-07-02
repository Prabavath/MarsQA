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
            string newLevel = languagePageObj.GetVerifyLevelAdd(driver);
            Assert.AreEqual("Telugu",newLanguage, "Actual language and expected language do not match");
            Assert.AreEqual("Fluent", newLevel, "Actual level and expected level do not match");

        }

        
        [When(@"Update '([^']*)','([^']*)' on an existing language details")]
        public void WhenUpdateOnAnExistingLanguageDetails(string language,string level)
        {
            LanguagePage languagePageObj = new LanguagePage();
            languagePageObj.UpdateLanguage(driver,language,level);
        }

        [Then(@"Language should been updated '([^']*)','([^']*)'")]
        public void ThenLanguageShouldBeenUpdated(string language,string level)
        {
            LanguagePage languagePageObj = new LanguagePage();
            string updatedLanguage = languagePageObj.GetVerifyUpdateLanguage(driver);
            string updatedLevel = languagePageObj.GetVerifyUpdateLevel(driver);
            Assert.AreEqual(language, updatedLanguage, "Actual language and expected language do not match");
            Assert.AreEqual(level, updatedLevel, "Actual level and expected level do not match");
        }

        [When(@"Delete '([^']*)','([^']*)' on an existing details")]
        public void WhenDeleteOnAnExistingDetails(string language, string level)
        {
            LanguagePage languagePageObj = new LanguagePage();
            languagePageObj.DeleteLanguage(driver, language, level);
        }
        [Then(@"Language should be deleted '([^']*)','([^']*)'")]
        public void ThenLanguageShouldBeDeleted(string language, string level)
        {
            LanguagePage languagePageObj = new LanguagePage();
            string deletedLanguage = languagePageObj.GetVerifyDeleteLanguage(driver);
            Assert.AreEqual(language, deletedLanguage, "Actual language and expected language do not match");
        }
        [AfterScenario]
        public void closeTestRun() 
        {
            driver.Quit();
        }
    }
}
