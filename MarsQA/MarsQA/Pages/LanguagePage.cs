using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsQA.Utilities;

namespace MarsQA.Pages
{
    public class LanguagePage : CommonDriver
    {
        public void AddLanguage(IWebDriver driver)
        {
            Thread.Sleep(2000);
            IWebElement addnewButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
            addnewButton.Click();


            Random random = new Random();
            string[] languages = { "Tamil", "English", "Telugu", "Kannada" };
            int index = random.Next(0,languages.Length);
            string randomLanguage = languages[index];

            IWebElement addlanguageTextbox = driver.FindElement(By.Name("name"));
            addlanguageTextbox.SendKeys(randomLanguage);

            IWebElement languageLevelDropdown = driver.FindElement(By.Name("level"));
            SelectElement select = new SelectElement(languageLevelDropdown);
            string[] languageLevel = { "Basic", "Cnversational", "Fluent", "Native/Billingual" };
            int randomIndex = random.Next(0,select.Options.Count);
            select.SelectByIndex(randomIndex);

            IWebElement addButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
            addButton.Click();
            Thread.Sleep(3000);
        }

        public string  GetVerifyLanguageAdd(IWebDriver driver)
        {
            Thread.Sleep(2000);
            IWebElement newLanguage = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]"));
            return newLanguage.Text;
        }

        

    }
}

