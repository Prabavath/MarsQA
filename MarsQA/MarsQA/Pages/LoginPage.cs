using MarsQA.Utilities;
using NUnit.Framework;
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
    public class LoginPage : CommonDriver
    {
        //Identify textbox and button
        private static IWebElement signinButton => driver.FindElement(By.XPath("//*[@id=\"home\"]/div/div/div[1]/div/a"));
        private static IWebElement emailaddressTextbox => driver.FindElement(By.Name("email"));
        private static IWebElement passwordTextbox => driver.FindElement(By.Name("password"));
        private static IWebElement remembermeCheckbox => driver.FindElement(By.Name("rememberDetails"));
        private static IWebElement loginButton => driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));

        public void LoginSteps()
        {
             //Launch Mars-QA application
             driver.Navigate().GoToUrl("http://localhost:5000");
             driver.Manage().Window.Maximize();

             //Enter input and click button
             signinButton.Click();
             emailaddressTextbox.SendKeys("prabavathini@yahoo.com");
             passwordTextbox.SendKeys("Password123");
             remembermeCheckbox.Click();
             loginButton.Click();
             Thread.Sleep(2000);
        
        }
    }
    
}
    
