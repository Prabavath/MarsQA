using MarsQA.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQA.Pages
{
    public class NegativeSkillPage : CommonDriver
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
        private static IWebElement updatedSkill => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[1]"));
        private static IWebElement updatedLevel => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[2]"));
      

        public void AddSkill(string skill, string level)
        {
            //Get input and click butoon
            Thread.Sleep(2000);
            skillTab.Click();
            addnewButton.Click();
            addSkillTextbox.SendKeys(skill);
            skillLevelOption.SendKeys(level);
            addButton.Click();
            Thread.Sleep(2000);
            IWebElement messageBox = driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));
            Thread.Sleep(2000);
            //get the text of the message element
            string actualMessage = messageBox.Text;
            Console.WriteLine(actualMessage);

            //Verify the expected message text
            string expectedMessage1 = skill + " has been added to your skills";
            string expectedMessage2 = "Please enter skill and experience level";
            string expectedMessage3 = "This skill is already exist in your skill list.";
           
            Assert.That(actualMessage, Is.EqualTo(expectedMessage1).Or.EqualTo(expectedMessage2).Or.EqualTo(expectedMessage3));

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

        public void UpdateSkill(string skill, string level)
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
            Thread.Sleep(2000);
            IWebElement messageBox = driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));
            Thread.Sleep(2000);
            //get the text of the message element
            string actualMessage = messageBox.Text;
            Console.WriteLine(actualMessage);

            //Verify the expected message text
            string expectedMessage4 = skill + " has been updated to your skills";
            string expectedMessage5 = "Please enter skill and experience level";
            string expectedMessage6 = "This skill is already exist in your skill list.";

            Assert.That(actualMessage, Is.EqualTo(expectedMessage4).Or.EqualTo(expectedMessage5).Or.EqualTo(expectedMessage6));

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

    }
}
