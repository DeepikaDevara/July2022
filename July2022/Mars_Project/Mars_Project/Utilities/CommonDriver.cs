using Mars_Project.Page;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Mars_Project.Utilities
{
    public class CommonDriver
    {
        public static IWebDriver driver;
        Login loginPageObj = new Login(driver);
        ProfileNEducation profile = new ProfileNEducation(driver);
        [SetUp]
        public void LoginActions()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            loginPageObj.LoginSteps(driver);
            profile.welcomeMessage(driver);

        }

        [OneTimeTearDown]
        public void CloseTestRun()
        {
            Thread.Sleep(2000);
            driver.Close();
        }
    }
}