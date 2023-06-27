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
            Thread.Sleep(2000);
            IWebElement skillTab = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            skillTab.Click();
            Thread.Sleep(2000);
            IWebElement addnewButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
            addnewButton.Click();                                   

            Random random = new Random();
            string[] skill = {"Java","API","C#","Selenium"};
            int index = random.Next(skill.Length);
            string randomSkill = skill[index];

            IWebElement addSkillTextbox = driver.FindElement(By.Name("name"));
            addSkillTextbox.SendKeys(randomSkill);
            string[] skillLevel = { "Beginner","Intermediate","Expert"};
            int index1 = random.Next(skillLevel.Length);
            string randomSkillLevel = skillLevel[index1];

            IWebElement skillLevelOption = driver.FindElement(By.Name("level"));
            skillLevelOption.SendKeys(randomSkillLevel);

            IWebElement addButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"));
            addButton.Click();
            Thread.Sleep(3000);
        }

        public string GetVerifySkillAdd(IWebDriver driver)
        {
            Thread.Sleep(2000);
            IWebElement newSkill = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[1]"));
            return newSkill.Text;
        }
    }
}
