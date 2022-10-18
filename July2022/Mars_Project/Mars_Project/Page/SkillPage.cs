using Mars_Project.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars_Project.Page
{
    public class SkillPage
    {
        IWebDriver Driver;
        public SkillPage(IWebDriver driver)
        {
            Driver = driver;
        }
        public void NavigateSkill(IWebDriver driver)
        {
            string SkillTab = "//div/section[2]/div/div/div/div[3]/form/div[1]/a[2]";
            WaitHelpers.WaitToBeClickable(driver, "XPath", SkillTab, 5);
            driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[1]/a[2]")).Click();
            Thread.Sleep(1000);
        }
        public void SkillAdd(IWebDriver driver, string skill)
        {
            Thread.Sleep(1000);
            //click on Add New button
            driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div")).Click();
            //enter skill
            driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[1]/input")).SendKeys(skill);
            //enter choose skill
            driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select")).Click();
            Thread.Sleep(1000);
            //choose level
            driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select/option[2]")).Click();

            //click on Add button
            driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]")).Click();
            Thread.Sleep(2000);

        }

        public string newSkill(IWebDriver driver)
        {
            string skillvisible = "//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[1]";

            WaitHelpers.WaitToBeVisible(driver, "XPath", skillvisible, 5);
            IWebElement newSkill = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
            return newSkill.Text;
        }

        public string newSkillLevel(IWebDriver driver)
        {
            string skillvisible = "//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[2]";
            WaitHelpers.WaitToBeVisible(driver, "XPath", skillvisible, 5);
            IWebElement newLevel = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[2]"));
            return newLevel.Text;
        }

        public void SkillEdit(IWebDriver driver, string skill)
        {
            string Editvisible = "//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[1]/i";
            WaitHelpers.WaitToBeVisible(driver, "XPath", Editvisible, 5);
            //Thread.Sleep(2000);
            //click on edit button
            driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[1]/i")).Click();
            Thread.Sleep(2000);
            //enter language
            //string languagevisible = "//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td/div/div[1]/input";
            //WaitHelpers.WaitToBeVisible(driver, "XPath", languagevisible, 5);
            IWebElement skillname = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td/div/div[1]/input"));
            skillname.Clear();
            skillname.SendKeys(skill);
            //enter level
            driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td/div/div[2]/select")).Click();
            //selecting native for level
            driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td/div/div[2]/select/option[4]")).Click();
            //click on submit button
            driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td/div/span/input[1]")).Click();
            Thread.Sleep(1000);


        }

        public string EditedSkill(IWebDriver driver)
        {
            IWebElement editedskill = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
            return editedskill.Text;
        }

        public string EditedSkillLevel(IWebDriver driver)
        {
            IWebElement editedskilllevel = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[2]"));
            return editedskilllevel.Text;
        }


        public void SkillDelete(IWebDriver driver)
        {
            //click on delete button
            driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[2]/i")).Click();
            Thread.Sleep(2000);

        }

        public string DeletedSkill(IWebDriver driver)
        {
            Thread.Sleep(2000);
            IWebElement deletedSkill = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
            return deletedSkill.Text;
        }
    }
}

