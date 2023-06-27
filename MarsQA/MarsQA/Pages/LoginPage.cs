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
    public class LoginPage : CommonDriver
    {
        public void LoginSteps(IWebDriver driver)
        {
            driver.Navigate().GoToUrl("http://localhost:5000");
            driver.Manage().Window.Maximize();
           
            IWebElement signinButton = driver.FindElement(By.XPath("//*[@id=\"home\"]/div/div/div[1]/div/a"));
            signinButton.Click();
            IWebElement emailaddressTextbox = driver.FindElement(By.Name("email"));
            emailaddressTextbox.SendKeys("prabavathini@yahoo.com");
            IWebElement passwordTextbox = driver.FindElement(By.Name("password"));
            passwordTextbox.SendKeys("Password123");
            IWebElement remembermeCheckbox = driver.FindElement(By.Name("rememberDetails"));
            remembermeCheckbox.Click();
            IWebElement loginButton = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
            loginButton.Click();
            Thread.Sleep(2000);
        }
    }
}
    
