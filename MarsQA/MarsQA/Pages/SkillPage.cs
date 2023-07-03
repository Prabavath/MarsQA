using MarsQA.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQA.Pages
{
    public class SkillPage : CommonDriver
    {
        public void AddSkill(IWebDriver driver)
        {
            IWebElement skillTab = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            skillTab.Click();
            Thread.Sleep(2000);

            IWebElement addnewButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
            addnewButton.Click();                                   
            IWebElement addSkillTextbox = driver.FindElement(By.Name("name"));
            addSkillTextbox.SendKeys("Java");
            IWebElement skillLevelOption = driver.FindElement(By.Name("level"));
            skillLevelOption.SendKeys("Beginner");
            IWebElement addButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"));
            addButton.Click();
            Thread.Sleep(2000);

            IWebElement addnewButton1 = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
            addnewButton1.Click();
            IWebElement addSkillTextbox1 = driver.FindElement(By.Name("name"));
            addSkillTextbox1.SendKeys("API");
            IWebElement skillLevelOption1 = driver.FindElement(By.Name("level"));
            skillLevelOption1.SendKeys("Intermediate");
            IWebElement addButton1 = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"));
            addButton1.Click();
            Thread.Sleep(2000);

            IWebElement addnewButton2 = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
            addnewButton2.Click();
            IWebElement addSkillTextbox2 = driver.FindElement(By.Name("name"));
            addSkillTextbox2.SendKeys("C#");
            IWebElement skillLevelOption2 = driver.FindElement(By.Name("level"));
            skillLevelOption2.SendKeys("Beginner");
            IWebElement addButton2 = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"));
            addButton2.Click();
            Thread.Sleep(2000);

            IWebElement addnewButton3 = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
            addnewButton3.Click();
            IWebElement addSkillTextbox3 = driver.FindElement(By.Name("name"));
            addSkillTextbox3.SendKeys("C#");
            IWebElement skillLevelOption3 = driver.FindElement(By.Name("level"));
            skillLevelOption3.SendKeys("Beginner");
            IWebElement addButton3 = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"));
            addButton3.Click();
        }

        public string GetVerifySkillAdd(IWebDriver driver)
        {
            Thread.Sleep(2000);
            IWebElement newSkill = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[1]/tr/td[1]"));
            return newSkill.Text;
        }
        public string GetVerifySkillLevel(IWebDriver driver)
        {
            Thread.Sleep(2000);
            IWebElement newSkillLevel = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[1]/tr/td[2]"));
            return newSkillLevel.Text;
        }

        public void UpdateSkill(IWebDriver driver, string skill, string level)
        {
            IWebElement skillTab = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            skillTab.Click();
            IWebElement editIcon = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[1]/tr/td[3]/span[1]/i"));
            editIcon.Click();
            IWebElement skillTextbox = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/div[1]/input"));
            skillTextbox.Clear();
            skillTextbox.SendKeys(skill);
            IWebElement levelTextbox = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/div[2]/select"));
            levelTextbox.Click();
            levelTextbox.SendKeys(level);
            IWebElement updateButton = driver.FindElement(By.XPath("//input[@value='Update']"));
            updateButton.Click();
        }
        public string GetVerifyUpdateSkill(IWebDriver driver)
        {
            Thread.Sleep(2000);
            IWebElement updatedSkill = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[1]/tr/td[1]"));
            return updatedSkill.Text;
        }
        public string GetVerifyUpdateLevel(IWebDriver driver)
        {
            Thread.Sleep(2000);
            IWebElement updatedLevel = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[1]/tr/td[2]"));
            return updatedLevel.Text;
        }

        public void DeleteSkill(IWebDriver driver, string skill, string level)
        {
            Thread.Sleep(2000);
            IWebElement skillTab = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            skillTab.Click();
            IWebElement deleteIcon = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[3]/span[2]/i"));
            deleteIcon.Click();
        }
        public string GetVerifyDeleteSkill(IWebDriver driver)
        {
            IWebElement deletedSkill = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[1]/tr/td[1]"));
            return deletedSkill.Text;
        }
    }
    
}
