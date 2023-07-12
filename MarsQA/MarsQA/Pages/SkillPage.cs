using MarsQA.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQA.Pages
{
    public class SkillPage : CommonDriver
    {
        //Identify inputtextbox and button
        private static IWebElement skillTab => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
        private static IWebElement addnewButton => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
        private static IWebElement addSkillTextbox => driver.FindElement(By.Name("name"));
        private static IWebElement skillLevelOption => driver.FindElement(By.Name("level"));
        private static IWebElement addButton => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"));
        private static IWebElement newSkill => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
        private static IWebElement newSkillLevel => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[2]"));
        private static IWebElement editIcon => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[1]/tr/td[3]/span[1]/i"));
        private static IWebElement skillTextbox => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/div[1]/input"));
        private static IWebElement levelTextbox => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/div[2]/select"));
        private static IWebElement updateButton => driver.FindElement(By.XPath("//input[@value='Update']"));
        private static IWebElement updatedSkill => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[1]/tr/td[1]"));
        private static IWebElement updatedLevel => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[1]/tr/td[2]"));
        private static IWebElement deletedSkill => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[1]/tr/td[1]"));
        private static IWebElement deletedLevel => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[1]/tr/td[2]"));

        public void AddSkill(string skill,string level)
        {
            //Get input and click butoon
            Thread.Sleep(2000);
            skillTab.Click();
            addnewButton.Click();                                   
            addSkillTextbox.SendKeys(skill);
            skillLevelOption.SendKeys(level);
            addButton.Click();
                       
        }

        public string GetVerifySkillAdd()
        {
            Thread.Sleep(2000);
            return newSkill.Text;
        }
        public string GetVerifySkillLevel()
        {
            Thread.Sleep(2000);
            return newSkillLevel.Text;
        }

        public void UpdateSkill(string skill,string level)
        {
            //Get input and click button
            Thread.Sleep(2000);
            skillTab.Click();
            editIcon.Click();
            skillTextbox.Clear();
            skillTextbox.SendKeys(skill);
            levelTextbox.Click();
            levelTextbox.SendKeys(level);
            updateButton.Click();
        }
    
        public string GetVerifyUpdateSkill()
        {
            Thread.Sleep(2000);
            return updatedSkill.Text;
        }
        public string GetVerifyUpdateLevel()
        {
            Thread.Sleep(2000);
            return updatedLevel.Text;
        }

        public void DeleteSkill(string skill, string level)
        {
             Thread.Sleep(2000);
             skillTab.Click();
             var skillDeleteIcon = driver.FindElement(By.XPath($"//tbody[tr[td[text()='{skill}'] and td[text()='{level}']]]//i[@class='remove icon']"));
             // Find and click the delete icon in the row
             skillDeleteIcon.Click();
             Thread.Sleep(2000);
        }
        public string GetVerifyDeleteSkill()
        {
          Thread.Sleep(3000);
          return deletedSkill.Text;
        }
        public string GetVerifyDeleteLevel()
        {
            Thread.Sleep(2000);
            return deletedLevel.Text;
        }
    }
    
}
