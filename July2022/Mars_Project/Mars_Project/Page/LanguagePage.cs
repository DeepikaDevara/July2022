using Mars_Project.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars_Project.Page
{
    public class LanguagePage
    {
        IWebDriver Driver;
        public LanguagePage(IWebDriver driver)
        {
            Driver = driver;
        }
        public void NavigateLanguage(IWebDriver driver)
        {
            string LanguageTab = "//div/section[2]/div/div/div/div[3]/form/div[1]/a[1]";
            WaitHelpers.WaitToBeClickable(driver, "XPath", LanguageTab, 5);
            driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[1]/a[1]")).Click();
            Thread.Sleep(1000);
        }
        public void LanguageAdd(IWebDriver driver, string Language)
        {
            Thread.Sleep(1000);
            //click on Add New button
            driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div")).Click();
            //enter language
            driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input")).SendKeys(Language);
            //enter choose language
            driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select")).Click();
            Thread.Sleep(1000);
            //choose level
            driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[4]")).Click();

            //click on Add button
            driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]")).Click();
            Thread.Sleep(1000);

        }

        public string newLanguage(IWebDriver driver)
        {
            IWebElement newLanguage = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
            return newLanguage.Text;
        }

        public string newLevel(IWebDriver driver)
        {
            IWebElement newLevel = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td[2]"));
            return newLevel.Text;
        }

        public void LanguageEdit(IWebDriver driver, string Language)
        {
            string Editvisible = "//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[1]/i";
            WaitHelpers.WaitToBeVisible(driver, "XPath", Editvisible, 5);
            //Thread.Sleep(2000);
            //click on edit button
            driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[1]/i")).Click();
            Thread.Sleep(2000);
            //enter language
            //string languagevisible = "//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td/div/div[1]/input";
            //WaitHelpers.WaitToBeVisible(driver, "XPath", languagevisible, 5);
            IWebElement language = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td/div/div[1]/input"));
            language.Clear();
            language.SendKeys(Language);

            // Thread.Sleep(1000);
            //enter level
            driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td/div/div[2]/select")).Click();
            //selecting native for level
            driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td/div/div[2]/select/option[5]")).Click();
            //click on submit button
            driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td/div/span/input[1]")).Click();
            Thread.Sleep(2000);


        }

        public string EditedLanguage(IWebDriver driver)
        {
            Thread.Sleep(2000);
            IWebElement editedlanguage = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
            return editedlanguage.Text;
        }

        public string EditedLevel(IWebDriver driver)
        {
            IWebElement editedlevel = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[2]"));
            return editedlevel.Text;
        }


        public void LanguageDelete(IWebDriver driver)
        {
            Thread.Sleep(1000);
            //click on delete button
            driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[2]/i")).Click();
            Thread.Sleep(2000);

        }

        public string DeletedLanguage(IWebDriver driver)
        {
            Thread.Sleep(2000);
            IWebElement deletedlanguage = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
            return deletedlanguage.Text;
          
        }

    }

}


