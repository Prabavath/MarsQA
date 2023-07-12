using MarsQA.Pages;
using MarsQA.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace MarsQA.StepDefinitions
{
    [Binding]
    public class LanguageFeatureStepDefinitions : CommonDriver
    {
         //Loginpage and languagepage object initialization
         LoginPage loginPageObj;
         LanguagePage languagePageObj;
                
        public LanguageFeatureStepDefinitions()
        {
            loginPageObj = new LoginPage();
            languagePageObj = new LanguagePage();
        }

        [Given(@"User has successfully logged into Mars-QA application")]
        public void GivenUserHasSuccessfullyLoggedIntoMars_QAApplication()
        {   
            loginPageObj.LoginSteps();
        }

        [When(@"Add language'([^']*)','([^']*)' into user profile")]
        public void WhenAddLanguageIntoUserProfile(string language, string level)
        {   
            languagePageObj.AddLanguage(language, level);
        }

        [Then(@"Languages should be added '([^']*)','([^']*)' successfully")]
        public void ThenLanguagesShouldBeAddedSuccessfully(string language, string level)
        {
            string newLanguage = languagePageObj.GetVerifyLanguageAdd();
            string newLevel = languagePageObj.GetVerifyLevelAdd();
            Assert.AreEqual(language, newLanguage, "Actual language and expected language do not match");
            Assert.AreEqual(level, newLevel, "Actual level and expected level do not match");

        }

                      
        [When(@"Update '([^']*)','([^']*)' on an existing language details")]
        public void WhenUpdateOnAnExistingLanguageDetails(string language,string level)
        {
           languagePageObj.UpdateLanguage(language,level);
        }

        [Then(@"Language should been updated '([^']*)','([^']*)'")]
        public void ThenLanguageShouldBeenUpdated(string language,string level)
        {
            string updatedLanguage = languagePageObj.GetVerifyUpdateLanguage();
            string updatedLevel = languagePageObj.GetVerifyUpdateLevel();
            Assert.AreEqual(language, updatedLanguage, "Actual language and expected language do not match");
            Assert.AreEqual(level, updatedLevel, "Actual level and expected level do not match");
        }



        [When(@"Delete '([^']*)','([^']*)' on an existing details")]
        public void WhenDeleteOnAnExistingDetails(string language, string level)
        {
           languagePageObj.DeleteLanguage(language, level);
        }
        [Then(@"Language should be deleted '([^']*)','([^']*)'")]
        public void ThenLanguageShouldBeDeleted(string language,string level)
        {
            string deletedLanguage = languagePageObj.GetVerifyDeleteLanguage();
            string deletedLevel = languagePageObj.GetVerifyDeleteLevel();
            Assert.AreNotEqual(language, deletedLanguage, "Actual language and expected language do not match");
            Assert.AreNotEqual(level, deletedLevel, "Actual level and expected level do not match");
        }
        
    }
}

