using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsQA.Utilities;
using System.Reflection.Emit;

namespace MarsQA.Pages
{
    public class LanguagePage : CommonDriver
    {
        //Identify inputtextbox and button
        private static IWebElement addnewButton => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
        private static IWebElement addlanguageTextbox => driver.FindElement(By.Name("name"));
        private static IWebElement languageLevelOption => driver.FindElement(By.Name("level"));
        private static IWebElement addButton => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
        private static IWebElement editIcon => driver.FindElement(By.XPath("//td[@class='right aligned']//i[@class='outline write icon']"));
        private static IWebElement getLanguageTextbox => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/div[1]/input"));
        private static IWebElement getLevelTextbox => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/div[2]/select"));
        private static IWebElement updateButton => driver.FindElement(By.XPath("//input[@value='Update']"));
        private static IWebElement newLanguage => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
        private static IWebElement newLevel => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[2]"));
        private static IWebElement updatedLanguage => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td[1]"));
        private static IWebElement updatedLevel => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td[2]"));
        private static IWebElement deletedLanguage => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]"));
        private static IWebElement deletedLevel => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[2]"));

        public void AddLanguage(string language,string level)
        {
            //Get input and click button
            addnewButton.Click();
            addlanguageTextbox.SendKeys(language);
            languageLevelOption.SendKeys(level);
            addButton.Click();
            Thread.Sleep(3000);

        }
        public string  GetVerifyLanguageAdd()
        {            
            return newLanguage.Text;
        }
        public string GetVerifyLevelAdd()
        {
            return newLevel.Text;
        }


        public void UpdateLanguage(string language, string level)
        {
            //Get input and click button 
            Thread.Sleep(2000);
            editIcon.Click();
            getLanguageTextbox.Clear();
            getLanguageTextbox.SendKeys(language);
            getLevelTextbox.Click();
            getLevelTextbox.SendKeys(level);
            updateButton.Click(); 
                   
        }
        public string GetVerifyUpdateLanguage()
        {
            Thread.Sleep(2000);
            return updatedLanguage.Text;
        }
        public string  GetVerifyUpdateLevel()
        {
            Thread.Sleep(2000);
            return updatedLevel.Text;
        }

        public void DeleteLanguage(string language, string level)
        {
            Thread.Sleep(2000);
            // Find all rows in the table
            IReadOnlyCollection<IWebElement> rows = driver.FindElements(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr"));
            Thread.Sleep(2000);

            foreach (IWebElement row in rows)
            {
                // Get the text of the first column (language column) in the row
                IWebElement languageElement = row.FindElement(By.XPath("./td[1]"));
                IWebElement languageLevel = row.FindElement(By.XPath("./td[2]"));
                string languageText = languageElement.Text;
                string languageLevelText = languageLevel.Text;
                Thread.Sleep(2000);

                // Check if the language matches the provided text
                if (languageText.Equals(language, StringComparison.OrdinalIgnoreCase) && languageLevelText.Equals(level, StringComparison.OrdinalIgnoreCase))
                {
                    // Find and click the delete icon in the row
                    IWebElement deleteIcon = row.FindElement(By.XPath("./td[3]/span[2]/i"));
                   // Thread.Sleep(2000);
                    deleteIcon.Click();
                    Thread.Sleep(2000);
                    break;
                }
                                         
            }
        }
                 
        public string GetVerifyDeleteLanguage()
        {
            Thread.Sleep(2000);
            return deletedLanguage.Text;
        }
        public string GetVerifyDeleteLevel()
        {
            Thread.Sleep(2000);
            return deletedLevel.Text;
        }
    }
}

