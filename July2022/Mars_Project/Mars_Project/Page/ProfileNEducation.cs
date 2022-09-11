using Mars_Project.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Mars_Project.Page
{
    public class ProfileNEducation
    {
        public string welcomeMessage(IWebDriver driver)
        {
            string welcomeText = "//div/div[1]/div[2]/div/span";
            WaitHelpers.WaitToBeVisible(driver, "XPath", welcomeText, 5);
            IWebElement welcomeMessage = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/div[1]/div[2]/div/span"));
            return welcomeMessage.Text;
        }
        public void NavigateEducation(IWebDriver driver)
        {
            //Thread.Sleep(1000);
            //Navigate to education tab
            string EducationTab = "//div/section[2]/div/div/div/div[3]/form/div[1]/a[3]";
            WaitHelpers.WaitToBeClickable(driver, "XPath", EducationTab, 5);
            driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[1]/a[3]")).Click();
            Thread.Sleep(1000);
        }
        public void AddEducation(IWebDriver driver)
        {
            Thread.Sleep(1000);
            //click on add new in education tab
            driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[6]/div")).Click();
            //Enter College/University name
            driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[1]/input")).SendKeys("AUT");
            //country of the college/ university is selecting 
            driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[2]/select")).Click();
            //New Zealand is selecting as the country
            driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[2]/select/option[102]")).Click();
            //select Title
            driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[1]/select")).Click();
            //selecting B-Tech as course
            driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[1]/select/option[7]")).Click();
            //Enter Degree
            driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[2]/input")).SendKeys("Bachelor");
            //click on Year of graduation
            driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[3]/select")).Click();
            // Select year of graduation
            driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[3]/select/option[5]")).Click();
            //Click on Add button
            driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[3]/div/input[1]")).Click();
            Thread.Sleep(1000);
        }

        public string NewCollege(IWebDriver driver)
        {
            IWebElement NewCollege = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[2]"));
            return NewCollege.Text;
        }

        public void EditEducation(IWebDriver driver, string College, string country)
        {
            Thread.Sleep(1000);
            //Navigate to education tab
            driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[1]/a[3]")).Click();
            //Edit button in education click
            driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[6]/span[1]/i")).Click();
            //Edit College/University name
            IWebElement collegeEdit = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[1]/div[1]/input"));
            collegeEdit.Clear();
            collegeEdit.SendKeys(College);
            //selecting the country
            IWebElement TitleEdit = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[2]/div[2]/input"));
            TitleEdit.Clear();
            TitleEdit.SendKeys(country);

            IWebElement TitleNEdit = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[1]/div[2]/select"));
            TitleNEdit.Click();
            driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[1]/div[2]/select/option[11]")).Click();
            //Edit Degree
            IWebElement degreeEdit = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[2]/div[1]/select"));
            degreeEdit.Click();
            IWebElement degree = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[2]/div[1]/select/option[8]"));
            degree.Click();
            //submit
            driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[3]/input[1]")).Click();
            Thread.Sleep(1000);
        }

        public string EditedCollege(IWebDriver driver)
        {
            IWebElement editedCollege = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[2]"));
            return editedCollege.Text;
        }
        public string EditedTitle(IWebDriver driver)
        {
            IWebElement editedTitle = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[4]"));
            return editedTitle.Text;
        }


        public void DeleteEducation(IWebDriver driver)
        {
            //Navigate to education tab
            driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[1]/a[3]")).Click();
            Thread.Sleep(1000);
            //Delete button click
            driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[6]/span[2]/i")).Click();
            Thread.Sleep(1000);


        }
        public string deletedCollege(IWebDriver driver)
        {
            Thread.Sleep(1000);


            IWebElement deletedCollege = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[2]"));
            return deletedCollege.Text;



        }

    }
}