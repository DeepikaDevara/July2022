using Mars_Project.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars_Project.Page
{
    public class PasswordChangePage
    {
        IWebDriver Driver;
        public PasswordChangePage(IWebDriver driver)
        {
            Driver = driver;
        }
        public string welcomeMessage(IWebDriver driver)
        {
            string welcomeText = "//div/div[1]/div[2]/div/span";
            WaitHelpers.WaitToBeVisible(driver, "XPath", welcomeText, 5);
            IWebElement welcomeMessage = driver.FindElement(By.XPath("//div/div[1]/div[2]/div/span"));
            return welcomeMessage.Text;
        }
        public void NavigateChangePassword(IWebDriver driver)
        {

            string welcomeText = "//div/div[1]/div[2]/div/span";
            WaitHelpers.WaitToBeVisible(driver, "XPath", welcomeText, 5);
            driver.FindElement(By.XPath("//div/div[1]/div[2]/div/span")).Click();
            string pwdchange = "//div/div[1]/div[2]/div/span/div/a[2]";
            WaitHelpers.WaitToBeVisible(driver, "XPath", pwdchange, 5);
            driver.FindElement(By.XPath("//div/div[1]/div[2]/div/span/div/a[2]")).Click();
            Thread.Sleep(2000);


        }
        public void ChangePassword(IWebDriver driver, string oldPassword, string newPassword)
        {
            string oldpwd = "/html/body/div[4]/div/div[2]/form/div[1]/input";
            WaitHelpers.WaitToBeVisible(driver, "XPath", oldpwd, 5);
            IWebElement Oldpassword = driver.FindElement(By.XPath("/html/body/div[4]/div/div[2]/form/div[1]/input"));
            Oldpassword.Clear();
            Oldpassword.SendKeys(oldPassword);
            string newpwd = "/html/body/div[4]/div/div[2]/form/div[2]/input";
            WaitHelpers.WaitToBeVisible(driver, "XPath", newpwd, 5);

            IWebElement NewPassword = driver.FindElement(By.XPath("/html/body/div[4]/div/div[2]/form/div[2]/input"));
            NewPassword.Clear();
            NewPassword.SendKeys(newPassword);
            string newconfirmpwd = "/html/body/div[4]/div/div[2]/form/div[3]/input";
            WaitHelpers.WaitToBeVisible(driver, "XPath", newconfirmpwd, 5);
            driver.FindElement(By.XPath("/html/body/div[4]/div/div[2]/form/div[3]/input")).SendKeys(newPassword);
            string save = "/html/body/div[4]/div/div[2]/form/div[4]/button";
            WaitHelpers.WaitToBeVisible(driver, "XPath", save, 5);
            driver.FindElement(By.XPath("/html/body/div[4]/div/div[2]/form/div[4]/button")).Click();
            //string popup = driver.FindElement(By.XPath("/html/body/div[1]/div")).Text;
            
            Thread.Sleep(2000);
        }

        public string DefaultModal(IWebDriver driver)
        {
            IWebElement pwdHeader = driver.FindElement(By.XPath("/html/body/div[4]/div/div[1]"));
            return pwdHeader.Text;

        }
    }
}

