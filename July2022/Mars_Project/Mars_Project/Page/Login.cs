using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars_Project.Page

{
    public class Login
    {
        IWebDriver Driver;
        public Login(IWebDriver driver)
        {
            Driver = driver;
        }

        public void LoginSteps(IWebDriver driver)
        {

            driver.Manage().Window.Maximize();

            //navigate to the portal 
            driver.Navigate().GoToUrl("192.168.1.208:5000");

            Thread.Sleep(4000);

            try
            {
                //find and click on  sign in button
                driver.FindElement(By.XPath("//*[@id='home']/div/div/div[1]/div/a")).Click();
                //enter valid email ID for the email address
                driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input")).SendKeys("dee@gmail.com");
                //enter valid Password for the email address
                driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input")).SendKeys("Apples123");
                //click on Login button
                driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button")).Click();
                Thread.Sleep(2000);


            }

            catch (Exception ex)
            {
                Assert.Fail("TurnUp portal page did not launch.", ex.Message);
                //Console.WriteLine("TurnUp portal page did not launch.", ex.Message);
            }

        }



    }
}