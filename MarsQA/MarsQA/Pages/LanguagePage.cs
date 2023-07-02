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
            IWebElement addnewButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
            addnewButton.Click();
            IWebElement addlanguageTextbox = driver.FindElement(By.Name("name"));
            addlanguageTextbox.SendKeys("Telugu");
            IWebElement languageLevelOption = driver.FindElement(By.Name("level"));
            languageLevelOption.SendKeys("Fluent");
            IWebElement addButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
            addButton.Click();
            Thread.Sleep(3000);

            IWebElement addnewButton1 = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
            addnewButton1.Click();
            IWebElement addlanguageTextbox1 = driver.FindElement(By.Name("name"));
            addlanguageTextbox1.SendKeys("s@1122");
            IWebElement languageLevelOption1 = driver.FindElement(By.Name("level"));
            languageLevelOption1.SendKeys("Fluent");
            IWebElement addButton1 = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
            addButton1.Click();
            Thread.Sleep(2000);
            
            IWebElement addnewButton2 = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
            addnewButton2.Click();
            IWebElement addlanguageTextbox2 = driver.FindElement(By.Name("name"));
            addlanguageTextbox2.SendKeys(" ");
            IWebElement languageLevelOption2 = driver.FindElement(By.Name("level"));
            languageLevelOption2.SendKeys("Native/Billingual");
            IWebElement addButton2 = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
            addButton2.Click();
            Thread.Sleep(2000);

            IWebElement addnewButton3 = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
            addnewButton3.Click();
            IWebElement addlanguageTextbox3 = driver.FindElement(By.Name("name"));
            addlanguageTextbox3.SendKeys("Kannada");
            IWebElement languageLevelOption3 = driver.FindElement(By.Name("level"));
            languageLevelOption3.SendKeys("Conversational");
            IWebElement addButton3 = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
            addButton3.Click();
            
        }

        public string  GetVerifyLanguageAdd(IWebDriver driver)
        {
            
            IWebElement newLanguage = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]"));
            return newLanguage.Text;
        }
        public string GetVerifyLevelAdd(IWebDriver driver)
        {
            IWebElement newLevel = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[2]"));
            return newLevel.Text;
        }


        public void UpdateLanguage(IWebDriver driver, string language, string level)
        {
            IWebElement editIcon = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td[3]/span[1]/i"));
            editIcon.Click();
            Thread.Sleep(2000);
            IWebElement getLanguageTextbox = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/div[1]/input"));
            getLanguageTextbox.Clear();
            getLanguageTextbox.SendKeys(language);
            Thread.Sleep(3000);
            IWebElement getLevelTextbox = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/div[2]/select"));
            getLevelTextbox.Click();
            getLevelTextbox.SendKeys(level);
            IWebElement updateButton = driver.FindElement(By.XPath("//input[@value='Update']"));
            updateButton.Click(); 
            
            
        }
        public string GetVerifyUpdateLanguage(IWebDriver driver)
        {
            Thread.Sleep(2000);
            IWebElement updatedLanguage = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td[1]"));
            return updatedLanguage.Text;
        }
        public string  GetVerifyUpdateLevel(IWebDriver driver)
        {
            Thread.Sleep(2000);
            IWebElement updatedLevel = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td[2]"));
            return updatedLevel.Text;
        }

        public void DeleteLanguage(IWebDriver driver, string language, string level)
        {

            IWebElement deleteIcon = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[2]/i"));
            deleteIcon.Click();                                  
                                                                 
        }
        public string GetVerifyDeleteLanguage(IWebDriver driver)
        {
            IWebElement deletedLanguage = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td[1]"));
            return deletedLanguage.Text;

        }
    }
}

