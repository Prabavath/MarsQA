using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQA.Utilities
{
    public class CommonDriver
    {
        public static IWebDriver driver;
        public void Initialize()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }
        public void close()
        {
            driver.Close();
        }
    }
}
